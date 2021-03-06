﻿using Colorful;
using CommandLine;
using System;
using System.Drawing;
using System.IO;
using trifenix.arguments;

namespace trifenix.versions.console
{

    /// <summary>
    /// # trifenix-versions
    /// Aplicación para la actualización de github de paquetes dependientes de una versión
    /// y para generar nuevas versiones de acuerdo a la rama.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Punto de arranque
        /// </summary>
        /// <param name="args">usamos CommandLineParser para parsear las opciones</param>
        static void Main(string[] args)
        {
            

            var currentDitectory = AppDomain.CurrentDomain.BaseDirectory;
            var fontPath = Path.Combine(currentDitectory, "figlet/small");
            var fontTitle = new Figlet(Colorful.FigletFont.Load(fontPath));

            Parser.Default.ParseArguments<UpdateVersionArgs, Propagation>(args).MapResult(
                (UpdateVersionArgs s)=> {
                    Update(s);
                    return 1;
                }, 
                (Propagation s) => {
                    Colorful.Console.WriteLine(fontTitle.ToAscii("Trifenix Connect"), Color.Red);

                    // metadata model
                    Colorful.Console.WriteLine(fontTitle.ToAscii("Trifenix-Versions"), Color.Purple);
                    Colorful.Console.WriteLine($"Propagación de dependencias para {s.packageName} rama {s.branch}", Color.DarkGreen);
                    Colorful.Console.WriteLine($"---------------------------------------------------", Color.DarkGreen);

                    ProgragationMethod(s);
                    return 1;
                },
                err=>1
                );


            

        }


        /// <summary>
        /// Actualización del paquete en los distintas dependencias.
        /// </summary>
        /// <param name="args">Argumentos de propagación, los mismos del update + build</param>
        public static void ProgragationMethod(Propagation args) {

            // version main
            var versionSpec = new VersionSpec(args.GitAddress, args.branch, args.Token, args.packageName, args.packageType, args.DependantRelease, args.username, args.email);

            try
            {
               

                versionSpec.SetVersionToDependant((message)=> Colorful.Console.WriteLine($"${message}", Color.Green));
            }
            catch (Exception ex)
            {
                Colorful.Console.WriteLine($"Error en la ejecución {ex.Message}", Color.Red);
                Colorful.Console.WriteLine($"Error en la ejecución {ex.StackTrace}", Color.Red);
                if (ex.InnerException !=null)
                {
                    Colorful.Console.WriteLine($"Error en la ejecución {ex.InnerException.Message}", Color.DarkRed);
                    Colorful.Console.WriteLine($"Error en la ejecución {ex.InnerException.StackTrace}", Color.DarkRed);
                }

            }
        }



        public static void Update(UpdateVersionArgs args) {

            var versionSpec = new VersionSpec(args.GitAddress, args.branch, args.Token, args.packageName, args.packageType, args.DependantRelease, args.username, args.email, args.Build);

            try
            {
                var version = versionSpec.SetVersion((s)=> { });
                System.Console.WriteLine(version);
            }
            catch (Exception ex)
            {

                Colorful.Console.WriteLine($"Error en la ejecución {ex.Message}", Color.Red);
            }

            
            
        }
    }
}

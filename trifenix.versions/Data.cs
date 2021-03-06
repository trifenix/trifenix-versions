﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using trifenix.versions.model;

namespace trifenix.versions
{
    /// <summary>
    /// Información usada en los tests
    /// </summary>
    public static class Data
    {
        // dependencies

        public static VersionStructure Interfaces = new VersionStructure
        {
            PackageName = "trifenix.connect.interfaces",
            GithubHttp = "https://github.com/trifenix/interfaces-connect.git",
            GithubSsh = "git@github.com:trifenix/interfaces-connect.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion{
                    Branch="master",
                    DependantRelease=false,
                    IsFeature=false,
                    PreReleaseLabel=string.Empty,
                    Preview=0,
                    SemanticBaseVersion=new Semantic { // actual versión
                        Major = 0,
                        Minor = 8,
                        Patch=13
                    }
                }
            },
            Dependencies = new List<Dependency>{
                new Dependency{
                     PackageName = "trifenix.connect.graph",
                     GithubHttp = "https://github.com/trifenix/graph.git",
                     GithubSsh = "git@github.com:trifenix/graph.git",
                    pathPackageSettings="trifenix.connect.graph.csproj"
                },
                new Dependency{
                    PackageName = "trifenix.connect.aad.auth",
                    GithubHttp = "https://github.com/trifenix/connect-azr-auth.git",
                    GithubSsh = "git@github.com:trifenix/connect-azr-auth.git",
                    pathPackageSettings="trifenix.connect.aad.auth.csproj"
                },
                new Dependency{
                    PackageName = "trifenix.connect.email",
                    GithubHttp = "https://github.com/trifenix/trifenix-connect-email.git",
                    GithubSsh = "git@github.com:trifenix/trifenix-connect-email.git",
                    pathPackageSettings="trifenix.connect.email.csproj"
                },
                new Dependency{
                    PackageName = "trifenix.connect.translate",
                    GithubHttp = "https://github.com/trifenix/connect-translate.git",
                    GithubSsh = "git@github.com:trifenix/connect-translate.git",
                    pathPackageSettings="trifenix.connect.translate.csproj"
                },
                new Dependency{
                        PackageName="trifenix.connect.db.cosmos",
                        GithubHttp="https://github.com/trifenix/trifenix-cosmos-db.git",
                        GithubSsh="git@github.com:trifenix/trifenix-cosmos-db.git",
                        pathPackageSettings="trifenix.connect.db.cosmos.csproj"
                    },
                new Dependency{
                        PackageName = "trifenix.connect.search", // los paquetes de npm usan trifenix al principio
                        GithubHttp = "https://github.com/trifenix/connect-search.git",
                        GithubSsh = "git@github.com:trifenix/connect-search.git",
                        pathPackageSettings="trifenix.connect.search.csproj"
                    },
                new Dependency{
                        PackageName = "trifenix.connect.storage.azure",
                        GithubHttp = "https://github.com/trifenix/connect-storage-azure.git",
                        GithubSsh = "git@github.com:trifenix/connect-storage-azure.git",
                        pathPackageSettings="trifenix.connect.storage.azure.csproj"
                    },
                new Dependency{
                    PackageName="trifenix.connect",
                    GithubHttp="https://github.com/trifenix/connect.git",
                    GithubSsh="git@github.com:trifenix/connect.git",
                    pathPackageSettings="connect/trifenix.connect.csproj"
                },
                
                new Dependency{
                    PackageName = "trifenix.connect.interfaces.external",
                    GithubHttp = "https://github.com/trifenix/external-search-cosmos.git",
                    GithubSsh = "git@github.com:trifenix/external-search-cosmos.git",            
                    pathPackageSettings="trifenix.connect.interfaces.external.csproj"
                },
            }
        };

        
        public static VersionStructure Cosmos => new VersionStructure
        {
            PackageName = "trifenix.connect.db.cosmos",
            GithubHttp = "https://github.com/trifenix/trifenix-cosmos-db.git",
            GithubSsh = "git@github.com:trifenix/trifenix-cosmos-db.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 54
                        }
                    }
                }
            ,
            Dependencies = new List<Dependency> { 
                new Dependency{
                    PackageName = "trifenix.connect.agro",
                    GithubHttp = "https://github.com/trifenix/trifenix.connect.agro.git",
                    GithubSsh = "git@github.com:trifenix/trifenix.connect.agro.git",
                    pathPackageSettings = "trifenix.connect.agro.csproj"
                }
            }
        };

        





        public static VersionStructure Connect => new VersionStructure
        {
            PackageName = "trifenix.connect",
            GithubHttp = "https://github.com/trifenix/connect.git",
            GithubSsh = "git@github.com:trifenix/connect.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 86
                        }
                    }
                }

        };


        public static VersionStructure SearchModel => new VersionStructure
        {
            PackageName = "trifenix.connect.mdm.search.model",
            GithubHttp = "https://github.com/trifenix/connect-azr-search-model.git",
            GithubSsh = "git@github.com:trifenix/connect-azr-search-model.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 50
                        }
                    }
                },
            Dependencies = new List<Dependency> {

                    new Dependency{
                        PackageName = "trifenix.connect.search", // los paquetes de npm usan trifenix al principio
                        GithubHttp = "https://github.com/trifenix/connect-search.git",
                        GithubSsh = "git@github.com:trifenix/connect-search.git",
                        pathPackageSettings="trifenix.connect.search.csproj"
                    }
                }
        };

        public static VersionStructure Bus => new VersionStructure
        {
            PackageName = "trifenix.connect.bus",
            GithubHttp = "https://github.com/trifenix/trifenix-connect-bus.git",
            GithubSsh = "git@github.com:trifenix/trifenix-connect-bus.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 47
                        }
                    }
                },
        };




        public static VersionStructure Mdm = new VersionStructure
        {
            PackageName = "trifenix.connect.mdm",
            GithubHttp = "https://github.com/trifenix/mdm.git",
            GithubSsh = "git@github.com:trifenix/mdm.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion{
                    Branch="master",
                    DependantRelease=false,
                    IsFeature=false,
                    PreReleaseLabel=string.Empty,
                    Preview=0,
                    SemanticBaseVersion=new Semantic { // actual versión
                        Major = 0,
                        Minor = 8,
                        Patch=149
                    }
                }
            },
            Dependencies = new List<Dependency>{
                
                 new Dependency{
                    PackageName = "trifenix.connect.interfaces",
                    GithubHttp = "https://github.com/trifenix/interfaces-connect.git",
                    GithubSsh = "git@github.com:trifenix/interfaces-connect.git",
                    pathPackageSettings="trifenix.connect.interfaces.csproj"
                },
                new Dependency{
                    PackageName="trifenix.connect.mdm.search.model",
                    GithubHttp="https://github.com/trifenix/connect-azr-search-model.git",
                    GithubSsh="git@github.com:trifenix/connect-azr-search-model.git",
                    pathPackageSettings="trifenix.connect.mdm.search.model.csproj"
                },
                new Dependency{
                    PackageName="trifenix.connect.bus",
                    GithubHttp="https://github.com/trifenix/trifenix-connect-bus.git",
                    GithubSsh="git@github.com:trifenix/trifenix-connect-bus.git",
                    pathPackageSettings="trifenix.connect.bus.csproj"
                }
            }
        };

        public static VersionStructure External => new VersionStructure
        {
            PackageName = "trifenix.connect.interfaces.external",
            GithubHttp = "https://github.com/trifenix/external-search-cosmos.git",
            GithubSsh = "git@github.com:trifenix/external-search-cosmos.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 50
                        }
                    }
                },
        };

        public static VersionStructure Storage => new VersionStructure
        {
            PackageName = "trifenix.connect.storage.azure",
            GithubHttp = "https://github.com/trifenix/connect-storage-azure.git",
            GithubSsh = "git@github.com:trifenix/connect-storage-azure.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 47
                        }
                    }
                }
        };

        public static VersionStructure Connectsearch = new VersionStructure
        {
            PackageName = "trifenix.connect.search", // los paquetes de npm usan trifenix al principio
            GithubHttp = "https://github.com/trifenix/connect-search.git",
            GithubSsh = "git@github.com:trifenix/connect-search.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion{
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic { // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch=47
                        }
                    }
                }
        };

        public static VersionStructure Translate => new VersionStructure
        {
            PackageName = "trifenix.connect.translate",
            GithubHttp = "https://github.com/trifenix/connect-translate.git",
            GithubSsh = "git@github.com:trifenix/connect-translate.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 52
                        }
                    }
                },
        };

        public static VersionStructure Email => new VersionStructure
        {
            PackageName = "trifenix.connect.email",
            GithubHttp = "https://github.com/trifenix/trifenix-connect-email.git",
            GithubSsh = "git@github.com:trifenix/trifenix-connect-email.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 52
                        }
                    }
                },
        };

        public static VersionStructure Graph => new VersionStructure
        {
            PackageName = "trifenix.connect.graph",
            GithubHttp = "https://github.com/trifenix/graph.git",
            GithubSsh = "git@github.com:trifenix/graph.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 53
                        }
                    }
                },
        };

        public static VersionStructure Auth => new VersionStructure
        {
            PackageName = "trifenix.connect.aad.auth",
            GithubHttp = "https://github.com/trifenix/connect-azr-auth.git",
            GithubSsh = "git@github.com:trifenix/connect-azr-auth.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 22
                        }
                    }
                },
        };


        public static VersionStructure Arguments => new VersionStructure
        {
            PackageName = "trifenix.connect.arguments",
            GithubHttp = "https://github.com/trifenix/trifenix-connect-arguments.git",
            GithubSsh = "git@github.com:trifenix/trifenix-connect-arguments.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 8,
                            Patch= 48
                        }
                    }
                },
            Dependencies = new List<Dependency>{

                    new Dependency{
                        PackageName="trifenix.connect.db.cosmos",
                        GithubHttp="https://github.com/trifenix/trifenix-cosmos-db.git",
                        GithubSsh="git@github.com:trifenix/trifenix-cosmos-db.git",
                        pathPackageSettings="trifenix.connect.db.cosmos.csproj"
                    }


                }

        };


        public static VersionStructure Mdmts => new VersionStructure
        {
            PackageName = "trifenix.connect.mdm.ts_model",
            GithubHttp = "https://github.com/trifenix/mdm-ts.git",
            GithubSsh = "git@github.com:trifenix/mdm-ts.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 11,
                            Patch= 5
                        }
                    }
                },
        };

        // falta
        public static VersionStructure mdmcli => new VersionStructure
        {
            PackageName = "mdm-cli",
            GithubHttp = "https://github.com/trifenix/mdm-cli.git",
            GithubSsh = "git@github.com:trifenix/mdm-cli.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 12,
                            Patch= 5
                        }
                    }
                },
        };


        public static VersionStructure AgroDataNuget => new VersionStructure
        {
            PackageName = "trifenix.connect.agro",
            GithubHttp = "https://github.com/trifenix/trifenix.connect.agro.git",
            GithubSsh = "git@github.com:trifenix/trifenix.connect.agro.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 0,
                            Patch= 0
                        }
                    }
                },
        };

        public static VersionStructure gitInterfaces => new VersionStructure
        {
            PackageName = "trifenix.git.interfaces",
            GithubHttp = "https://github.com/trifenix/git-interface.git",
            GithubSsh = "git@github.com:trifenix/git-interface.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 0,
                            Patch= 2
                        }
                    }
                },
            Dependencies = new List<Dependency>{

                    new Dependency{
                        PackageName = "trifenix.git",
                        GithubHttp = "https://github.com/trifenix/trifenix-git.git",
                        GithubSsh = "git@github.com:trifenix/trifenix-git.git",
                        pathPackageSettings="trifenix.git.csproj"
                    }


                }
        };

        public static VersionStructure git => new VersionStructure
        {
            PackageName = "trifenix.git",
            GithubHttp = "https://github.com/trifenix/trifenix-git.git",
            GithubSsh = "git@github.com:trifenix/trifenix-git.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 0,
                            Patch= 2
                        }
                    }
                },
        };
        public static VersionStructure modelVersions => new VersionStructure
        {
            PackageName = "trifenix.versions.model",
            GithubHttp = "https://github.com/trifenix/trifenix.versions.model.git",
            GithubSsh = "git@github.com:trifenix/trifenix.versions.model.git",
            PackageType = PackageType.nuget,
            Versions = new List<CommitVersion>{
                    new CommitVersion {
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic{ // actual versión
                            Major = 0,
                            Minor = 0,
                            Patch= 0
                        }
                    }
                },
        };









        public static VersionStructure agroData = new VersionStructure
        {
            PackageName = "trifenix_agro-data",
            GithubHttp = "https://github.com/trifenix/agro-data.git",
            GithubSsh = "git@github.com:trifenix/agro-data.git",
            
            Versions = new List<CommitVersion>{
                    new CommitVersion{
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic { // actual versión
                            Major = 0,
                            Minor = 1,
                            Patch=30
                        }
}
                }
        };

        public static VersionStructure MdmNpm = new VersionStructure
        {
            PackageName = "trifenix_mdm", // los paquetes de npm usan trifenix al principio
            GithubHttp = "https://github.com/trifenix/mdm-auto-npm-model.git",
            GithubSsh = "git@github.com:trifenix/mdm-auto-npm-model.git",
            PackageType = PackageType.npm,
            Versions = new List<CommitVersion>{
                    new CommitVersion{
                        Branch="master",
                        DependantRelease=false,
                        IsFeature=false,
                        PreReleaseLabel=string.Empty,
                        Preview=0,
                        SemanticBaseVersion=new Semantic { // actual versión
                            Major = 1,
                            Minor = 6,
                            Patch=26
                        }
}
                },
            Dependencies = new List<Dependency>{
                    new Dependency{
                        PackageName="@trifenix/agro-data",
                        GithubHttp="https://github.com/trifenix/agro-data.git",
                        GithubSsh="git@github.com:trifenix/agro-data.git",
                        pathPackageSettings="package.json"
                    }
                }
        };



       


        /// <summary>
        /// Listado de dependencias a ser usada en la aplicación.
        /// </summary>
        public static VersionStructure[] Packages { get; set; } = new VersionStructure[] {

            Arguments, Connect,gitInterfaces, modelVersions, git , SearchModel, Bus, Mdm, Mdmts,MdmNpm, Graph, Auth, Email, Interfaces, Translate, Cosmos, Connectsearch, Storage, External, agroData, AgroDataNuget, mdmcli


         };

        public static MapperConfiguration Configuration<T1,T2>() {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });

        }

      

        public static IMapper Mapper => Configuration<VersionStructure, VersionStructure>().CreateMapper();

        public static IMapper MapperCommitVersion => Configuration<CommitVersion, CommitPackageVersion>().CreateMapper();





    }
}

﻿using System.Collections.Generic;
using System.Linq;
using trifenix.versions.interfaces;
using trifenix.versions.model;

namespace trifenix.versions.tests.mock
{

    public static partial class TestData
    {
        public static class Instances {

            public static IVersionSpec Default
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "master",
                    "build.devops",
                    "token.github",
                    "trifenix.connect",
                    PackageType.nuget,
                    false,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s=>s.PackageName.Equals("trifenix.connect"))),
                    Data.Packages.ToList()
                );

            public static IVersionSpec DefaultNullGithub
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "master",
                    "build.devops",
                    "token.github",
                    "trifenix.connect",
                    PackageType.nuget,
                    false,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(null),
                    Data.Packages.ToList()
                );

            public static IVersionSpec SetVersionStructureGithub(VersionStructure versionStructure)
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "master",
                    "build.devops",
                    "token.github",
                    "trifenix.connect",
                    PackageType.nuget,
                    false,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(versionStructure),
                    Data.Packages.ToList()
                );
            public static IVersionSpec SetVersionStructureWithoutDefaultGithub(VersionStructure versionStructure)
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "master",
                    "build.devops",
                    "token.github",
                    "trifenix.connect",
                    PackageType.nuget,
                    false,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(versionStructure),
                    new List<VersionStructure>()
                );

            public static IVersionSpec DevelopRelease
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "develop",
                    "build.devops",
                    "token.github",
                    "trifenix.connect.interfaces",
                    PackageType.nuget,
                    true,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s => s.PackageName.Equals("trifenix.connect.interfaces"))),
                    Data.Packages.ToList()
                );

            public static IVersionSpec FeatureNoRelease
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "develop",
                    "build.devops",
                    "token.github",
                    "test.package.feature",
                    PackageType.nuget,
                    true,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s => s.PackageName.Equals("trifenix.connect"))),
                    Data.Packages.ToList()
                );

            public static IVersionSpec NpmMasterNoRelease
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "master",
                    "build.devops",
                    "token.github",
                    "test.npm.package",
                    PackageType.npm,
                    false,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s => s.PackageName.Equals("trifenix.connect"))),
                    Data.Packages.ToList()
                );


            public static IVersionSpec NpmDevelopNoRelease
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "develop",
                    "build.devops",
                    "token.github",
                    "@trifenix/mdm",
                    PackageType.npm,
                    false,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s => s.PackageName.Equals("trifenix@mdm"))),
                    Data.Packages.ToList()
                );

            public static IVersionSpec NpmDevelopNoReleaseCustomBranchRelease
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "test-branch",
                    "build.devops",
                    "token.github",
                    "trifenix@mdm",
                    PackageType.npm,
                    true,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s => s.PackageName.Equals("trifenix@mdm"))),
                    Data.Packages.ToList()
                );

            public static IVersionSpec NpmDevelopNoReleaseBranch
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "release",
                    "build.devops",
                    "token.github",
                    "trifenix@mdm",
                    PackageType.npm,
                    true,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s => s.PackageName.Equals("trifenix@mdm"))),
                    Data.Packages.ToList()
                );

            public static IVersionSpec NpmFeatureRelease
                => new VersionSpec(
                    "GIT HUB REPO, NO SE UTILIZA EN TEST",
                    "feature/npm-test",
                    "build.devops",
                    "token.github",
                    "test.npm.package.feature",
                    PackageType.npm,
                    true,
                    Mock.GitRepo(),
                    Mock.GitRepoVersionStructure(Data.Packages.First(s => s.PackageName.Equals("trifenix.connect"))),
                    Data.Packages.ToList()
                );
        }
    }
}

﻿using System.Linq;
using trifenix.versions.model;
using trifenix.versions.tests.mock;
using Xunit;

namespace trifenix.versions.tests
{

    public partial class VersionSpecTest {
        public class SetMainVersion { 
            
            [Fact]
            public void SetStructureMasterWithoutRelease() {
                var spec = TestData.Instances.Default;

                var package = Data.Mapper.Map<VersionStructure>(Data.Packages.First(s => s.PackageName.Equals("trifenix.connect")));

                var lastPackageVersion = package.Versions.Where(s => s.Branch.Equals("master")).Max(s => s.SemanticBaseVersion.Patch);
                var version = spec.SetMainVersion(package);
                var newPatch = version.Versions.Where(s => s.Branch.Equals("master")).Max(s => s.SemanticBaseVersion.Patch);
                Assert.Equal(lastPackageVersion + 1, newPatch);
            }

            [Fact]
            public void CheckWithDevelopBranch()
            {
                var spec = TestData.Instances.DevelopRelease;
                var package = Data.Mapper.Map<VersionStructure>(Data.Packages.First(s => s.PackageName.Equals("trifenix.connect.interfaces")));

                var versionMaster = package.Versions.First();
                var version = spec.SetMainVersion(package);
                var lastVersionDate = version.Versions.Max(s => s.LastUpdate);
                var lastVersion = version.Versions.First(s => s.LastUpdate.Equals(lastVersionDate));

                Assert.True(versionMaster.SemanticBaseVersion.Equals(lastVersion.SemanticBaseVersion));

                Assert.True(lastVersion.PreReleaseLabel.Equals("preview"));
            }

          


        }


    }
}

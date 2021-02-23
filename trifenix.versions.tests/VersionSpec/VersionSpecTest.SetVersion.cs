﻿using trifenix.versions.tests.mock;
using Xunit;

namespace trifenix.versions.tests
{

    public partial class VersionSpecTest {

        public class SetVersion { 
            
            [Fact]
            public void SetVersionMasterCheckVersion() {
                var spec = TestData.Instances.Default;

                var version = spec.SetVersion();

                Assert.Equal("0.8.78", version);
            }

            [Fact]
            public void SetFeatureCheckVersion()
            {
                var spec = TestData.Instances.DevelopRelease;

                var version = spec.SetVersion();

                Assert.Equal("0.8.13.preview.1", version);
            }
        }


    }
}

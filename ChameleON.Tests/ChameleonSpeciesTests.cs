using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;

namespace ChameleON.Tests
{
    [TestClass]
    public class ChameleonSpeciesTests
    {
        public class ChameleonSpeciesTest
        {
            public NameValueCollection nvc;

            public bool SampleFeatureAlpha { get { return new Chameleon(nvc).ToggleOn; } }
            public bool SampleFeatureBravo { get { return new Chameleon(nvc).ToggleOn; } }
            public bool SampleFeatureCharlie { get { return new Chameleon(nvc).ToggleOn; } }
            public bool SampleFeatureDelta { get { return new Chameleon(nvc).ToggleOn; } }
            public bool SampleFeatureEcho { get { return new Chameleon(nvc).ToggleOn; } }
            public bool SampleFeatureFoxtrot { get { return new Chameleon(nvc).ToggleOn; } }
            public bool SampleFeatureGolf { get { return new Chameleon(nvc, "SampleFeatureHotel").ToggleOn; } }

            public ChameleonSpeciesTest(NameValueCollection settings)
            {
                nvc = settings;
            }
        }

        [TestMethod]
        public void TestConfigurationSettings()
        {
            NameValueCollection settings = new NameValueCollection();
            settings.Add("Chameleon.SampleFeatureAlpha", "True");
            settings.Add("Chameleon.SampleFeatureBravo", "true");
            settings.Add("Chameleon.SampleFeatureCharlie", "False");
            settings.Add("Chameleon.SampleFeatureDelta", "false");
            settings.Add("Chameleon.SampleFeatureEcho", "Garbage!");
            settings.Add("Chameleon.SampleFeatureHotel", "true");

            ChameleonSpeciesTest chameleon = new ChameleonSpeciesTest(settings);

            // True values
            Assert.IsTrue(chameleon.SampleFeatureAlpha);
            Assert.IsTrue(chameleon.SampleFeatureBravo);

            // False values
            Assert.IsFalse(chameleon.SampleFeatureCharlie);
            Assert.IsFalse(chameleon.SampleFeatureDelta);

            // Bad or missing values
            Assert.IsFalse(chameleon.SampleFeatureEcho);
            Assert.IsFalse(chameleon.SampleFeatureFoxtrot);

            // Overridden values
            Assert.IsTrue(chameleon.SampleFeatureGolf);
        }
    }
}
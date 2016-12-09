using System.Collections.Specialized;

namespace ChameleON
{
    public class ConfigurationSettings
    {
        private static readonly string Prefix = "Chameleon.";

        private NameValueCollection Settings;

        public ConfigurationSettings(NameValueCollection settings)
        {
            Settings = settings;
        }

        /// <summary>
        /// Fetch toggle from configuration file.
        /// </summary>
        /// <remarks>
        /// Chameleon's tongue is propelled by incredible speed: it takes 0.07 seconds for its tongue to reach its victim.
        /// </remarks>
        public bool Tongue(string Victim)
        {
            bool insect = false;
            if (!string.IsNullOrEmpty(Victim))
            {
                if (bool.TryParse(Settings[string.Concat(Prefix, Victim)], out insect))
                {
                    return insect;
                }
            }
            return insect;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChameleON
{
    public class ConfigurationSettings
    {
        private static readonly string Prefix = "Chameleon.";

        /// <summary>
        /// Fetch toggle from configuration file.
        /// </summary>
        /// <remarks>
        /// Chameleon's tongue is propelled by incredible speed: it takes 0.07 seconds for its tongue to reach its victim.
        /// </remarks>
        public bool Tounge(string Victim)
        {
            bool insect = false;
            try
            {
                if (!string.IsNullOrEmpty(Victim))
                {
                    insect = bool.Parse(System.Configuration.ConfigurationManager.AppSettings[string.Concat(Prefix, Victim)]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            return insect;
        }
    }
}


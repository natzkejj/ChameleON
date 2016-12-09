using System.Collections.Specialized;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ChameleON
{
    /// <summary>
    /// Chameleon is more than just a lizard.
    /// </summary>
    public class Chameleon : IChromatophores
    {
        private string ToggleName = "";

        private NameValueCollection Settings;

        public Chameleon([CallerMemberName]string methodName = "")
            : this(ConfigurationManager.AppSettings, methodName)
        {
        }

        public Chameleon(NameValueCollection settings, [CallerMemberName]string methodName = "")
        {
            Settings = settings == null ? new NameValueCollection() : settings;
            ToggleName = methodName;
        }

        public bool ToggleOn
        {
            get
            {
                return new ConfigurationSettings(Settings).Tongue(ToggleName);
            }
        }
    }
}
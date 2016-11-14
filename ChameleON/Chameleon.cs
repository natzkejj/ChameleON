

namespace ChameleON
{
    /// <summary>
    /// Chameleon is more than just a lizard.
    /// </summary>
    public class Chameleon : IChromatophores
    {
        private string ToggleName = "";
        public Chameleon([System.Runtime.CompilerServices.CallerMemberName]string methodName= "")
        {
            ToggleName = methodName;
        }

        public bool ToggleOn
        {
            get
            {
                return new ConfigurationSettings().Tounge(ToggleName);
            }
        }

    }   
}

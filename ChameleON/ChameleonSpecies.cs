using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChameleON
{
    /// <summary>
    /// Custom Toggles
    /// </summary>
    /// <remarks>
    /// There are around 160 species of chameleons which can be found mostly on the Madagascar (half of all species live there), in the Africa, southern Europe, south Asia and Sri Lanka.
    /// </remarks>
    public class ChameleonSpecies
    {
        [Obsolete("Release is over: go-live 11/10")]
        public bool NovemberRelease
        {
            get
            {
                return new Chameleon().ToggleOn;
            }
        }

        public bool DecemberRelease
        {
            get
            {
                return new Chameleon().ToggleOn;
            }
        }

        public bool QuickPayR2
        {
            get
            {
                return new Chameleon().ToggleOn;
            }
        }
    }
}

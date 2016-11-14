using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChameleON
{
    /// <summary>
    /// Chromatophores are special cells that have a pigment in them. These cells lie in layers under a chameleon's outer skin allowing them to change colors.
    /// </summary>
    public interface IChromatophores
    {
        bool ToggleOn
        {
            get;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine;

using GTA;

namespace LCFR
{

    /// <summary>
    /// Class for creating a wrapper of a <see cref="Player"/>. Allows for custom functions when calling the <see cref="LPlayer"/>
    /// </summary>
    public class LPlayer : WrappedPlayer
    {

        public LPlayer(LCFREngine engine, Player player) : base(engine, player) { }

    }

    /// <summary>
    /// Class for creating a wrapper of a <see cref="Ped"/>. Allows for custom functions when calling the <see cref="LPed"/>
    /// </summary>
    public class LPed : WrappedPed
    {

        public LPed(LCFREngine engine, Ped ped) : base(engine, ped) { }

    }

}

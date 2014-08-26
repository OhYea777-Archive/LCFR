using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine;

using GTA;

namespace LCFR
{

    public class LPlayer : WrappedPlayer
    {

        public LPlayer(LCFREngine engine, Player player) : base(engine, player) { }

    }

}

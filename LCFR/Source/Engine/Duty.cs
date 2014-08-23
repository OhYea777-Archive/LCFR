using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GTA;

namespace Engine
{
    class Duty : Script
    {
        public void onDuty()
        {
            if (KeyHandler.bOnDuty)
            {

                Utils.drawString("on duty code in here from Duty.cs");
            }
        }
    }
}

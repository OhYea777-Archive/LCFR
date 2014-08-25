using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Engine;
using GTA;

namespace LCFR
{
    public class initMain : Script
    {
        public initMain()
        {
            //LCFREngine.Utils.drawString("Welcome to Liberty City First Responder!");

            Utils.drawTopLeftString("Welcome to Liberty City First Responder!\nVersion 0.1\n\nPress");

            // don't need to call anything here
            // we may call a messagebox or something here to display a welcome message or
            // just call that in the Engine.cs file
        }
    }
}

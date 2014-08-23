using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GTA;

namespace Engine
{
    /// <summary>
    /// Ped spawning/controller
    /// </summary>
    class Peds : Script
    {
        GTA.Ped ped;
        class Ped_Spawn
        {
            private static void spawnPed(int type, String[] pedList, int gender)
            {
               // ped = GTA.World.CreatePed(GTA.Vector3.Zero);
            }
        }
    }

    /// <summary>
    /// Handler for all key press
    /// </summary>
    class KeyHandler : Script
    {
        public KeyHandler()
        {
            this.KeyDown += new GTA.KeyEventHandler(KeyPressDown);
        }
        
        // check if player is onDuty
        public static bool bOnDuty = false;

        public static void KeyPressDown(object sender, GTA.KeyEventArgs e)
        {
            if (!bOnDuty)
            {
                if ((e.Key == Keys.Alt & Keys.D))// ((e.Key == Keys.Alt & e.Key == Keys.D)) // && !bOnDuty)
                {
                    bOnDuty = true;
                    Utils.drawString("bOnDuty == true");
                }
            }
            else if (bOnDuty)
            {

            }
        }
    }

    /// <summary>
    /// Utilities class for calling random functions
    /// </summary>
    class Utils : Script
    {
        public static void drawBox(int x, int y, string text, Color color, GraphicsEventArgs e)
        {
            // e.Graphics.DrawRectangle((int)(x + text.Length) )
        }


        public static void drawString(string message)
        {
            Game.DisplayText(message);
        }
    }
}

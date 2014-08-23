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

    public class LCFREngine : Script
    {

        private Duty duty;
        private KeyHandler keyHandler;

        public LCFREngine()
        {
            this.duty = new Duty(this);
            this.keyHandler = new KeyHandler(this);
        }

        public Duty getDuty()
        {
            return duty;
        }

        public KeyHandler getKeyHandler()
        {
            return keyHandler;
        }

        /// <summary>
        /// Ped spawning/controller
        /// </summary>
        public class Peds : Script
        {
           // GTA.Ped ped;
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
        public class KeyHandler
        {
            private LCFREngine engine;

            public KeyHandler(LCFREngine engine)
            {
                this.engine = engine;
                this.engine.BindKey(Keys.D, false, false, true, new KeyPressDelegate(dutyKey));
                this.engine.BindKey(Keys.Delete, false, false, false, new KeyPressDelegate(delCarsKey));
                this.engine.BindKey(Keys.H, true, true, true, new KeyPressDelegate(helpKey));
            }

            public void helpKey()
            {
                LCFREngine.Utils.drawTopLeftString("help menu");
            }

            public void dutyKey()
            {
                if (!engine.getDuty().bIsOnDuty)
                    engine.getDuty().beginDuty();
                else
                    engine.getDuty().endDuty();
            }

            // use only for development
            public void delCarsKey()
            {
                foreach (Vehicle veh in World.GetVehicles(Game.LocalPlayer.Character.Position, 175.0f))
                    if (Game.Exists(veh) && veh != Game.LocalPlayer.Character.CurrentVehicle)
                        veh.Delete();
            }

        }

        /// <summary>
        /// Utilities class for calling random functions
        /// </summary>
        public class Utils
        {
            public static void drawRect(int x, int y, string text, Color backgroundColor, Color textColor, GraphicsEventArgs e)
            {
                e.Graphics.DrawRectangle((int) (x + text.Length * 5.7), y + 12, (int) text.Length * 12, 25, backgroundColor);
                e.Graphics.DrawText(text, x, y, textColor);
            }

            public static void drawTopLeftString(string text)
            {
                Game.DisplayText(text, 5000);
            }

            public static void drawCenterBottomString(string text)
            {
                GTA.Native.Function.Call("PRINT_STRING_WITH_LITERAL_STRING_NOW", "STRING", text, 5000, 1);
            }
        }
    }
}

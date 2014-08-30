using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using LCFR;

using GTA;
using GTA.Native;

namespace Engine
{

    /// <summary>
    /// Main Engine class which loads all other classes/managers
    /// </summary>
    public class LCFREngine : Script
    {

        private LPlayer wrappedPlayer;

        private Duty duty;
        private KeyHandler keyHandler;
        private AddonManager addonManager;

        public LCFREngine()
        {
            this.duty = new Duty(this);
            this.wrappedPlayer = new LPlayer(this, Player);
            this.keyHandler = new KeyHandler(this);
            this.addonManager = new AddonManager(this);
        }

        /// <summary>
        /// Variable to get the <see cref="WrappedPlayer"/> instance
        /// </summary>
        public WrappedPlayer WrappedPlayer
        {
            get
            {
                return wrappedPlayer;
            }

            private set { }
        }

        /// <summary>
        /// Variable to get the <see cref="Duty"/> instance
        /// </summary>
        public Duty Duty
        {
            get
            {
                return duty;
            }

            private set { }
        }

        /// <summary>
        /// Variable to get the <see cref="KeyHandler"/> instance
        /// </summary>
        public KeyHandler KeyHandler
        {
            get
            {
                return keyHandler;
            }

            private set { }
        }

        /// <summary>
        /// Variable to get the <see cref="AddonManager"/> instance
        /// </summary>
        public AddonManager AddonManager
        {
            get
            {
                return addonManager;
            }

            private set { }
        }

        /// <summary>
        /// Function to bind a key. Made so that it can be accessed outside of the <see cref="LCFREngine"/> class
        /// </summary>
        public void bindKey(Keys key, bool shift, bool ctrl, bool alt, KeyPressDelegate e)
        {
            BindKey(key, shift, ctrl, alt, e);
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

            this.engine.bindKey(Keys.D, false, false, true, new KeyPressDelegate(dutyKey));
        }

        public void dutyKey()
        {
            if (!engine.WrappedPlayer.Duty.bIsOnDuty)
                engine.WrappedPlayer.Duty.beginDuty();
            else
                engine.WrappedPlayer.Duty.endDuty();
        }
    }

    /// <summary>
    /// Utilities class for calling random functions
    /// </summary>
    public class Utils
    {
        
        public static void drawRect(int x, int y, string text, Color backgroundColor, Color textColor, GraphicsEventArgs e)
        {
            e.Graphics.DrawRectangle((int)(x + text.Length * 5.7), y + 12, (int)text.Length * 12, 25, backgroundColor);
            e.Graphics.DrawText(text, x, y, textColor);
        }

        public static void drawTopLeftString(string text)
        {
            Game.DisplayText(text, 5000);
        }

        public static void drawCenterBottomString(string text)
        {
            Function.Call("PRINT_STRING_WITH_LITERAL_STRING_NOW", "STRING", text, 5000, 1);
        }

        public static double currentTimeInSeconds
        {
            get
            {
                return TimeSpan.FromTicks(DateTime.Now.Ticks).TotalSeconds;
            }

            private set { }
        }

    }

}

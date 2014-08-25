﻿using System;
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

    public class LCFREngine : Script
    {

        private WrappedPlayer wrappedPlayer;

        // neverused (output log)
        private Duty duty;
        private KeyHandler keyHandler;

        public LCFREngine()
        {
            this.wrappedPlayer = new WrappedPlayer(this, Player);
            this.keyHandler = new KeyHandler(this);
        }

        public KeyHandler KeyHandler
        {
            get
            {
                return keyHandler;
            }

            private set { }
        }

        public WrappedPlayer WrappedPlayer
        {
            get
            {
                return wrappedPlayer;
            }

            private set { }
        }

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
    }

}

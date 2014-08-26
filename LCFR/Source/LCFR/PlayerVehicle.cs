using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine;

using GTA;

namespace LCFR
{

    public class Pullover
    {

        private LCFREngine engine;

        public Pullover(LCFREngine engine)
        {
            this.engine = engine;
        }

        public void register()
        {
            engine.KeyDown += keyDown;
        }

        public void deRegister()
        {
            engine.KeyDown -= keyDown;
        }

        public void keyDown(object sender, KeyEventArgs e)
        {
            
        }
    }

    public class Speedometer : IAddon
    {

        private LCFREngine engine;

        public void onInitialize(LCFREngine engine)
        {
            this.engine = engine;
        }

        public void onKeyDown(object sender, KeyEventArgs args) { }

        public void onTick(object sender, EventArgs e) { }

        public void onFrameDraw(object sender, GraphicsEventArgs e)
        {
            if (engine.WrappedPlayer.Character.isInVehicle())
                e.Graphics.DrawText(System.Math.Floor(engine.WrappedPlayer.Character.CurrentVehicle.Speed * 2.2369).ToString() + " /mph", 0.9f, 0.1f);
        }

    }

}

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

        public void keyDown(object sender, GTA.KeyEventArgs e)
        {
            
        }

    }

    public class SpeedOMeter : Script
    {

        public SpeedOMeter()
        {
            this.PerFrameDrawing += new GraphicsEventHandler(speedometer);
        }

        public void speedometer(object sender, GraphicsEventArgs e)
        {
            if (Player.Character.isInVehicle())
                e.Graphics.DrawText(System.Math.Floor(Player.Character.CurrentVehicle.Speed * 2.2369).ToString() + " /mph", 0.9f, 0.1f);
        }

    }

}

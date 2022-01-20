using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AdvancedHookManaged;

using Engine;

using GTA;

namespace LCFR
{

    public class Pullover : IAddon
    {

        private const float DISTANCE = 10f;

        private LCFREngine engine;

        public void onInitialize(LCFREngine engine)
        {
            this.engine = engine;
        }

        public void onKeyDown(object sender, GTA.KeyEventArgs e)
        {
            if (engine.Duty.bIsOnDuty && e.Key == Keys.LShiftKey && engine.WrappedPlayer.Character.isInVehicle())
            {
                Vector3 pos = new LVector3(engine.WrappedPlayer.Character.Position).add(new LVector3(engine.WrappedPlayer.Character.CurrentVehicle.Direction).multiply(DISTANCE).x, new LVector3(engine.WrappedPlayer.Character.CurrentVehicle.Direction).multiply(DISTANCE).y, new LVector3(engine.WrappedPlayer.Character.CurrentVehicle.Direction).multiply(DISTANCE).z).toVector();

                Vehicle vehicle = World.GetClosestVehicle(pos, DISTANCE);

                if (vehicle != null && vehicle != engine.WrappedPlayer.Character.CurrentVehicle)
                {
                    AGame.PrintText("Pulling over suspect!");

                    GTA.Native.Function.Call("FORCE_PED_TO_FLEE_WHILST_DRIVING_VEHICLE", vehicle.GetPedOnSeat(VehicleSeat.Driver), vehicle);
                }
                else
                {
                    Utils.drawCenterBottomString("No Vehicle!");
                }
            }
        }

        public void onTick(object sender, EventArgs e) { }

        public void onFrameDraw(object sender, GraphicsEventArgs e) { }

    }

    public class Speedometer : IAddon
    {

        private LCFREngine engine;

        public void onInitialize(LCFREngine engine)
        {
            this.engine = engine;
        }

        public void onKeyDown(object sender, GTA.KeyEventArgs args) { }

        public void onTick(object sender, EventArgs e) { }

        public void onFrameDraw(object sender, GraphicsEventArgs e)
        {
            if (engine.WrappedPlayer.Character.isInVehicle())
                e.Graphics.DrawText(System.Math.Floor(engine.WrappedPlayer.Character.CurrentVehicle.Speed * 2.2369).ToString() + " /mph", 0.9f, 0.1f);
        }

    }

}

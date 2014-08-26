using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LCFR;
using GTA;

namespace Engine
{
    public class Duty
    {

        private LCFREngine engine;

        public const int DUTY_TIMEOUT = 10; // 300 5 mins

        public double endDutyTime = -1;
        public bool bIsOnDuty = false;

        public List<Vehicle> spawnedVehicles = new List<Vehicle>();

        // vehicle coordinates
        Vector3 vehicle1 = new Vector3(1043.25f, -795.979f, 3.1011f);
        Vector3 vehicle2 = new Vector3(1045.76f, -795.526f, 3.06828f);
        Vector3 vehicle3 = new Vector3(1048.27f, -795.073f, 3.04196f);
        Vector3 vehicle4 = new Vector3(1050.77f, -794.604f, 3.02422f);
        Vector3 vehicle5 = new Vector3(1053.27f, -794.135f, 3.01323f);
        Vector3 vehicle6 = new Vector3(1055.77f, -793.667f, 3.01755f);
        Vector3 vehicle7 = new Vector3(1069.22f, -784.487f, 3.82037f);
        Vector3 vehicle8 = new Vector3(1077.84f, -768.706f, 5.00823f);

        // player coordinates
        Vector3 onDutySpawn = new Vector3(1046.2f, -780.282f, 4.40463f);
        Vector3 offDutySpawn = new Vector3(921.073f, -577.344f, 14.1366f);

        // current model of player
        public Model currentModel;

        public Duty(LCFREngine engine)
        {
            this.engine = engine;

            this.engine.Tick += Tick;
        }

        public void beginDuty()
        {
            if (endDutyTime == -1 || Utils.currentTimeInSeconds - endDutyTime > DUTY_TIMEOUT)
            {
                this.currentModel = engine.WrappedPlayer.Model;
                bIsOnDuty = true;

                engine.WrappedPlayer.WantedLevel = 0;
                Game.WantedMultiplier = 0.0F;
                engine.WrappedPlayer.Money += 25000;
                Game.FadeScreenOut(5000, true);
                Game.FadeScreenIn(10000);
                engine.WrappedPlayer.Model = Model.BasicCopModel;
                engine.WrappedPlayer.Character.RandomizeOutfit();

                engine.WrappedPlayer.Character.Position = onDutySpawn;

                spawnedVehicles.Add(World.CreateVehicle(new Model("POLICE"), vehicle1));
                spawnedVehicles.Add(World.CreateVehicle(new Model("POLICE2"), vehicle2));
                spawnedVehicles.Add(World.CreateVehicle(new Model("POLPATRIOT"), vehicle3));
                spawnedVehicles.Add(World.CreateVehicle(new Model("NSTOCKADE"), vehicle4));
                spawnedVehicles.Add(World.CreateVehicle(new Model("FBI"), vehicle5));
                spawnedVehicles.Add(World.CreateVehicle(new Model("NOOSE"), vehicle6));
                spawnedVehicles.Add(World.CreateVehicle(new Model("POLMAV"), vehicle7));
                spawnedVehicles.Add(World.CreateVehicle(new Model("ANNIHILATOR"), vehicle8));

                Utils.drawTopLeftString("on duty message");
            }
            else
                Utils.drawTopLeftString("Time Left: " + (DUTY_TIMEOUT - (Convert.ToInt16(Utils.currentTimeInSeconds - endDutyTime))) + "s");
        }

        public void endDuty()
        {
            // in order to disable the "no police" you must disable that in the trainer
            endDutyTime = Utils.currentTimeInSeconds;

            // delete all vehicles in area (police)
            foreach (Vehicle veh in spawnedVehicles)
                if (Game.Exists(veh) && veh != Game.LocalPlayer.Character.CurrentVehicle)
                    veh.Delete();

            bIsOnDuty = false;
            Game.WantedMultiplier = 1.0F;
            engine.WrappedPlayer.Money -= 25000;
            Game.FadeScreenOut(5000, true);
            Game.FadeScreenIn(10000);
            engine.WrappedPlayer.Model = Model.FromString("PLAYER");

            engine.WrappedPlayer.Character.Position = offDutySpawn;

            Utils.drawTopLeftString("off duty message");
        }

        public void Tick(System.Object sender, EventArgs e)
        {
            if (bIsOnDuty && engine.WrappedPlayer.Character.isInVehicle())
            {
                for (int index = 0; index < spawnedVehicles.Count; index++)
                {
                    Vehicle veh = spawnedVehicles.ToArray()[index];
                    spawnedVehicles.RemoveAt(index);

                    if (Game.Exists(veh) && veh != engine.WrappedPlayer.Character.CurrentVehicle)
                        veh.Delete();
                }
            }
        }
    }
}

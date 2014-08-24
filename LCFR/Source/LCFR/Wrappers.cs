using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine;

using GTA;
using GTA.value;

namespace LCFR
{

    public class WrappedPlayer
    {

        private LCFREngine engine;
        private Player player;

        private Duty duty;

        public WrappedPlayer(LCFREngine engine, Player player)
        {
            this.engine = engine;
            this.player = player;
            
            this.duty = new Duty(engine);
        }

        public Player Player
        {
            get
            {
                return player;
            }

            private set { }
        }

        public Duty Duty
        {
            get
            {
                return duty;
            }

            private set { }
        }

        public Ped Character
        {
            get
            {
                return new WrappedPed(player.Character).Ped;
            }

            private set { }
        }

        public System.Drawing.Color Color
        {
            get
            {
                return player.Color;
            }

            private set { }
        }

        public int ID
        {
            get
            {
                return player.ID;
            }

            private set { }
        }

        public bool isPlaying
        {
            get
            {
                return player.isPlaying;
            }

            private set { }
        }

        public bool isPressingHorn
        {
            get
            {
                return player.isPressingHorn;
            }

            private set { }
        }

        public Vehicle LastVehicle
        {
            get
            {
                return player.LastVehicle;
            }

            private set { }
        }

        public Model Model
        {
            get
            {
                return player.Model;
            }
            set
            {
                player.Model = value;
            }
        }

        public int Money
        {
            get
            {
                return player.Money;
            }
            set
            {
                player.Money = value;
            }
        }

        public bool NeverGetsTired
        {
            private get { return false; }
            
            set
            {
                player.NeverGetsTired = value;
            }
        }

        public PlayerSkin Skin
        {
            get
            {
                return Player.Skin;
            }

            private set { }
        }

        public int WantedLevel
        {
            get
            {
                return player.WantedLevel;
            }
            set
            {
                player.WantedLevel = value;
            }
        }

        public WrappedPed getTargetedPed()
        {
            return new WrappedPed(player.GetTargetedPed());
        }

        public bool isTargetting(GTA.Object obj)
        {
            return player.isTargetting(obj);
        }

        public void SetComponentVisibility(GTA.PedComponent component, bool visible)
        {
            player.SetComponentVisibility(component, visible);
        }

        public void TeleportTo(Vector3 location)
        {
            player.TeleportTo(location);
        }

        public void TeleportTo(float x, float y, float z)
        {
            TeleportTo(new Vector3(x, y, z));
        }

    }

    public class WrappedPed
    {

        private Ped ped;

        public WrappedPed(Ped ped)
        {
            this.ped = ped;
        }

        public Ped Ped
        {
            get
            {
                return ped;
            }

            private set { }
        }

        public int Accuracy
        {   
            set
            {
                ped.Accuracy = value;
            }
        }

        public bool AlwaysDiesOnLowHealth
        {
            set
            {
                ped.AlwaysDiesOnLowHealth = value;
            }
        }

        public PedAnimation Animation
        {
            get
            {
                return ped.Animation;
            }

            private set { }
        }

        public int Armour
        {
            get
            {
                return ped.Armor;
            }
            set
            {
                ped.Armor = value;
            }
        }

        public bool BlockGestures
        {
            set
            {
                ped.BlockGestures = value;
            }
        }

        public bool BlockPermanentEvents
        {
            set
            {
                ped.BlockPermanentEvents = value;
            }
        }

        public bool BlockWeaponSwitching
        {
            set
            {
                ped.BlockWeaponSwitching = value;
            }
        }

        public bool CanBeDraggedOutOfVehicle
        {
            set
            {
                ped.CanBeDraggedOutOfVehicle = value;
            }
        }

        public bool CanBeKnockedOffBike
        {
            set
            {
                ped.CanBeKnockedOffBike = value;
            }
        }

        public bool CanSwitchWeapons
        {
            set
            {
                ped.CanSwitchWeapons = value;
            }
        }

        public bool CowerInsteadOfFleeing
        {
            set
            {
                ped.CowerInsteadOfFleeing = value;
            }
        }

        public Room CurrentRoom
        {
            get
            {
                return ped.CurrentRoom;
            }
            set
            {
                ped.CurrentRoom = value;
            }
        }

        public Vehicle CurrentVehicle
        {
            get
            {
                return ped.CurrentVehicle;
            }

            private set {  }
        }

        public Vector3 Direction
        {
            get
            {
                return ped.Direction;
            }

            private set { }
        }

        public bool DuckWhenAimedAtByGroupMember
        {
            set
            {
                ped.DuckWhenAimedAtByGroupMember = value;
            }
        }

    }

}

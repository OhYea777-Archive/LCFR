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

            this.duty = engine.Duty;
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

        public LPed Character
        {
            get
            {
                return new LPed(engine, player.Character);
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

        public LPed getTargetedPed()
        {
            return new LPed(engine, player.GetTargetedPed());
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

        private LCFREngine engine;
        private Ped ped;

        public WrappedPed(LCFREngine engine, Ped ped)
        {
            this.engine = engine;
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

        public bool Enemy
        {
            set
            {
                ped.Enemy = value;
            }
        }

        public Euphoria Euphoria
        {
            get
            {
                return ped.Euphoria;
            }

            private set { }
        }

        public float FireDamageMultiplier
        {
            set
            {
                ped.FireDamageMultiplier = value;
            }
        }

        public bool FreezePosition
        {
            set
            {
                ped.FreezePosition = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return ped.Gender;
            }

            private set { }
        }

        public float GravityMultiplier
        {
            set
            {
                ped.GravityMultiplier = value;
            }
        }

        public float Heading
        {
            get
            {
                return ped.Heading;
            }
            set
            {
                ped.Heading = value;
            }
        }

        public int Health
        {
            get
            {
                return ped.Health;
            }
            set
            {
                ped.Health = value;
            }
        }

        public float HeightAboveGround
        {
            get
            {
                return ped.HeightAboveGround;
            }

            private set { }
        }

        public bool Invincible
        {
            set
            {
                ped.Invincible = value;
            }
        }

        public bool isAlive
        {
            get
            {
                return ped.isAlive;
            }

            private set { }
        }

        public bool isAliveAndWell
        {
            get
            {
                return ped.isAliveAndWell;
            }

            private set { }
        }

        public bool isDead
        {
            get
            {
                return ped.isDead;
            }

            private set { }
        }

        public bool isGettingIntoAVehicle
        {
            get
            {
                return ped.isGettingIntoAVehicle;
            }

            private set { }
        }

        public bool isGettingUp
        {
            get
            {
                return ped.isGettingUp;
            }

            private set { }
        }

        public bool isIdle
        {
            get
            {
                return ped.isIdle;
            }

            private set { }
        }

        public bool isInAir
        {
            get
            {
                return ped.isInAir;
            }

            private set { }
        }

        public bool isInCombat
        {
            get
            {
                return ped.isInCombat;
            }

            private set { }
        }

        public bool isInGroup
        {
            get
            {
                return ped.isInGroup;
            }

            private set { }
        }

        public bool isInjured
        {
            get
            {
                return ped.isInjured;
            }

            private set { }
        }

        public bool isInMeleeCombat
        {
            get
            {
                return ped.isInMeleeCombat;
            }
            private set { }
        }

        public bool isInWater
        {
            get
            {
                return ped.isInWater;
            }

            private set { }
        }

        public bool isOnFire
        {
            get
            {
                return ped.isOnFire;
            }
            set
            {
                ped.isOnFire = value;
            }
        }

        public bool isOnScreen
        {
            get
            {
                return ped.isOnScreen;
            }

            private set { }
        }

        public bool isRagdoll
        {
            get
            {
                return ped.isRagdoll;
            }
            set
            {
                ped.isRagdoll = value;
            }
        }

        public bool isRequiredForMission
        {
            get
            {
                return ped.isRequiredForMission;
            }
            set
            {
                ped.isRequiredForMission = value;
            }
        }

        public bool isShooting
        {
            get
            {
                return ped.isShooting;
            }

            private set { }
        }

        public bool isSwimming
        {
            get
            {
                return ped.isSwimming;
            }

            private set { }
        }

        public int MaxHealth
        {
            set
            {
                ped.MaxHealth = value;
            }
        }

        public DynamicMetadata Metadata
        {
            get
            {
                return ped.Metadata;
            }

            private set { }
        }

        public Model Model
        {
            get
            {
                return ped.Model;
            }
        }

        public int Money
        {
            get
            {
                return ped.Money;
            }
            set
            {
                ped.Money = value;
            }
        }

        public PedType PedType
        {
            get
            {
                return ped.PedType;
            }

            private set { }
        }

        public Vector3 Position
        {
            get
            {
                return ped.Position;
            }
            set
            {
                ped.Position = value;
            }
        }

        public bool PreventRagdoll
        {
            set
            {
                ped.PreventRagdoll = value;
            }
        }

        public bool PriorityTargetForEnemies
        {
            set
            {
                ped.PriorityTargetForEnemies = value;
            }
        }

        public RelationshipGroup RelationshipGroup
        {
            get
            {
                return ped.RelationshipGroup;
            }
            set
            {
                ped.RelationshipGroup = value;
            }
        }

        public float SenseRange
        {
            set
            {
                ped.SenseRange = value;
            }
        }

        public PedSkin Skin
        {
            get
            {
                return ped.Skin;
            }

            private set { }
        }

        public PedTasks Task
        {
            get
            {
                return ped.Task;
            }

            private set { }
        }

        public Vector3 Velocity
        {
            get
            {
                return ped.Velocity;
            }
            set
            {
                ped.Velocity = value;
            }
        }

        public bool Visible
        {
            set
            {
                ped.Visible = value;
            }
        }

        public string Voice
        {
            set
            {
                ped.Voice = value;
            }
        }

        public bool WantedByPolice
        {
            set
            {
                ped.WantedByPolice = value;
            }
        }

        public WeaponCollection Weapons
        {
            get
            {
                return ped.Weapons;
            }

            private set { }
        }

        public bool WillDoDrivebys
        {
            set
            {
                ped.WillDoDrivebys = value;
            }
        }

        public bool WillFlyThroughWindscreen
        {
            set
            {
                ped.WillFlyThroughWindscreen = value;
            }
        }

        public bool WillUseCarsInCombat
        {
            set
            {
                ped.WillUseCarsInCombat = value;
            }
        }

        public void ApplyForce(Vector3 direction)
        {
            ped.ApplyForce(direction);
        }

        public void ApplyForce(Vector3 direction, Vector3 rotation)
        {
            ped.ApplyForce(direction, rotation);
        }

        public void ApplyForceRelative(Vector3 direction)
        {
            ped.ApplyForceRelative(direction);
        }

        public void ApplyForceRelative(Vector3 direction, Vector3 rotation)
        {
            ped.ApplyForceRelative(direction, rotation);
        }

        public Blip AttachBlip()
        {
            return ped.AttachBlip();
        }

        public void AttachTo(Vehicle vehicle, Vector3 offset)
        {
            ped.AttachTo(vehicle, offset);
        }

        public void BecomeMissionCharacter()
        {
            ped.BecomeMissionCharacter();
        }

        public void CancelAmbientSpeech()
        {
            ped.CancelAmbientSpeech();
        }

        public void CantBeDamagedByRelationshipGroup(RelationshipGroup group, bool value)
        {
            ped.CantBeDamagedByRelationshipGroup(group, value);
        }

        public void ChangeRelationship(RelationshipGroup group, Relationship level)
        {
            ped.ChangeRelationship(group, level);
        }

        public void Delete()
        {
            ped.Delete();
        }

        public void Detach()
        {
            ped.Detach();
        }

        public void Die()
        {
            ped.Die();
        }

        public void DropCurrentWeapon()
        {
            ped.DropCurrentWeapon();
        }

        public bool Equals(GTA.@base.HandleObject obj)
        {
            return ped.Equals(obj);
        }

        public bool Exists()
        {
            return ped.Exists();
        }

        public void FleeByVehicle(Vehicle vehicle)
        {
            ped.FleeByVehicle(vehicle);
        }

        public void ForceHelmet(bool enable)
        {
            ped.ForceHelmet(enable);
        }

        public void ForceRagdoll(int duration, bool tryToStayUpright)
        {
            ped.ForceRagdoll(duration, tryToStayUpright);
        }

        public Vector3 GetBonePosition(Bone bone)
        {
            return ped.GetBonePosition(bone);
        }

        public LPlayer GetControllingPlayer()
        {
            return new LPlayer(engine, ped.GetControllingPlayer());
        }

        public Vector3 GetOffsetPosition(Vector3 offset)
        {
            return ped.GetOffsetPosition(offset);
        }

        public void GiveFakeNetworkName(String name, System.Drawing.Color color)
        {
            ped.GiveFakeNetworkName(name, color);
        }

        public bool HasBeenDamagedBy(GTA.Weapon weapon)
        {
            return ped.HasBeenDamagedBy(weapon);
        }

        public bool isAttachedToVehicle()
        {
            return isAttachedToVehicle();
        }

        public bool isInArea(Vector3 cornerOne, Vector3 cornerTwo, bool ignoreHeight)
        {
            return isInArea(cornerOne, cornerTwo, ignoreHeight);
        }

        public bool isInVehicle()
        {
            return ped.isInVehicle();
        }

        public bool isInVehicle(Vehicle vehicle)
        {
            return ped.isInVehicle(vehicle);
        }

        public bool isSittingInVehicle()
        {
            return ped.isSittingInVehicle();
        }

        public bool isSittingInVehicle(Vehicle vehicle)
        {
            return ped.isSittingInVehicle(vehicle);
        }

        public bool isTouching(GTA.Object @object)
        {
            return ped.isTouching(@object);
        }

        public void LeaveGroup()
        {
            ped.LeaveGroup();
        }

        public void LeaveVehicle()
        {
            ped.LeaveVehicle();
        }

        public void MakeProofTo(bool bullets, bool fire, bool explosions, bool fallDamage, bool meleeAttacks)
        {
            ped.MakeProofTo(bullets, fire, explosions, fallDamage, meleeAttacks);
        }

        public void NoLongerNeeded()
        {
            ped.NoLongerNeeded();
        }

        public void RandomizeOutfit()
        {
            ped.RandomizeOutfit();
        }

        public void RemoveFakeNetworkName()
        {
            ped.RemoveFakeNetworkName();
        }

        public void SayAmbientSpeech(String phaseID)
        {
            ped.SayAmbientSpeech(phaseID);
        }

        public void SetDefaultVoice()
        {
            ped.SetDefaultVoice();
        }

        public void SetDefensiveArea(Vector3 position, float radius)
        {
            ped.SetDefensiveArea(position, radius);
        }

        public void SetPathfinding(bool allowClimbovers, bool allowLadders, bool allowDropFromHeight)
        {
            ped.SetPathfinding(allowClimbovers, allowLadders, allowDropFromHeight);
        }

        public void ShootAt(Vector3 position)
        {
            ped.ShootAt(position);
        }

        public void StartKillingSpree(bool alsoAttackPlayer)
        {
            ped.StartKillingSpree(alsoAttackPlayer);
        }

        public void WarpIntoVehicle(Vehicle vehicle, VehicleSeat seat)
        {
            ped.WarpIntoVehicle(vehicle, seat);
        }

    }

    public class LVector3
    {

        public float x, y, z;

        public LVector3(Vector3 vector)
        {
            this.x = vector.X;
            this.y = vector.Y;
            this.z = vector.Z;
        }

        public LVector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3 toVector()
        {
            return new Vector3(x, y, z);
        }

        public LVector3 multiply(float amount)
        {
            return multiply(amount, amount, amount);
        }

        public LVector3 multiply(Vector3 vector)
        {
            return multiply(vector.X, vector.Y, vector.Z);
        }

        public LVector3 multiply(LVector3 vector)
        {
            return multiply(vector.toVector());
        }

        public LVector3 multiply(float x, float y, float z)
        {
            this.x *= x;
            this.y *= y;
            this.z *= z;

            return this;
        }

        public LVector3 divide(float amount)
        {
            return divide(amount, amount, amount);
        }

        public LVector3 divide(Vector3 vector)
        {
            return divide(vector.X, vector.Y, vector.Z);
        }

        public LVector3 divide(LVector3 vector)
        {
            return divide(vector.toVector());
        }

        public LVector3 divide(float x, float y, float z)
        {
            this.x /= x;
            this.y /= y;
            this.z /= z;

            return this;
        }

        public LVector3 add(float amount)
        {
            return add(amount, amount, amount);
        }

        public LVector3 add(Vector3 vector)
        {
            return add(vector.X, vector.Y, vector.Z);
        }

        public LVector3 add(LVector3 vector)
        {
            return add(vector.toVector());
        }

        public LVector3 add(float x, float y, float z)
        {
            this.x += x;
            this.y += y;
            this.z += z;

            return this;
        }

        public LVector3 subtract(float amount)
        {
            return subtract(amount, amount, amount);
        }

        public LVector3 subtract(Vector3 vector)
        {
            return subtract(vector.X, vector.Y, vector.Z);
        }

        public LVector3 subtract(LVector3 vector)
        {
            return subtract(vector.toVector());
        }

        public LVector3 subtract(float x, float y, float z)
        {
            this.x -= x;
            this.y -= y;
            this.z -= z;

            return this;
        }

        public LVector3 zero()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;

            return this;
        }

    }

}

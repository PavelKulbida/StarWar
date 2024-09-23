namespace ServerLogic
{
    public class SpaceShip : UObject, IMovable, IRotatable
    {
        public SpacePoint Point { get; set; }

        public SpaceVelocity Velocity { get; set; }

        public int? Angle { get; set; }

        public int? AngleVelocity { get; set;  }
    }
}

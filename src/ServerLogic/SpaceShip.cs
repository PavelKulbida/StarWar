namespace ServerLogic
{
    public class SpaceShip : IMovable, IRotatable
    {
        public Guid Id { get; set; }

        public SpacePoint Point { get; set; }

        public SpaceVelocity Velocity { get; set; }

        public int? Angle { get; set; }

        public int? AngleVelocity { get; set;  }
    }
}

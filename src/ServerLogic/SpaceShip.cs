namespace ServerLogic
{
    public class SpaceShip : IMovable
    {
        public Guid Id { get; set; }

        public SpacePoint Point { get; set; } = null!;

        public SpaceVelocity Velocity { get; set; } = null!;
    }
}

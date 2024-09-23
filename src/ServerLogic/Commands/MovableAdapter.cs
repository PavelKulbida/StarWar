namespace ServerLogic.Commands
{
    internal class MovableAdapter : IMovable
    {
        public SpacePoint Point
        {
            get => _adaptee.Point;
            set => _adaptee.Point = value;
        }

        public SpaceVelocity Velocity
        {
            get => _adaptee.Velocity;
            set => _adaptee.Velocity = value;
        }

        private readonly IMovable _adaptee;

        public MovableAdapter(UObject adaptee)
        {
            _adaptee = (IMovable) adaptee;
        }
    }
}

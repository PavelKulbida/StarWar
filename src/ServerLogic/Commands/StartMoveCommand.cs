namespace ServerLogic.Commands
{
    public class StartMoveCommand : IMoveCommandStartable, ICommand
    {
        private IMovable _movableObject;
        private SpaceVelocity _velocity;
        private Queue<ICommand> _queue;

        public void SetCommandParameters(UObject SpaceObject, SpaceVelocity Velocity, Queue<ICommand> Queue)
        {
            _movableObject = new MovableAdapter(SpaceObject);
            _velocity = Velocity;
            _queue = Queue;
        }

        public void Execute()
        {
            _movableObject.Velocity = _velocity;

            var moveCommand = new MoveCommand(_movableObject);
            var command = new BridgeCommand(moveCommand);

            _queue.Enqueue(command);
        }
    }
}

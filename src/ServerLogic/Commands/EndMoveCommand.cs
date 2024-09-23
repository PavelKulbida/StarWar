namespace ServerLogic.Commands
{
    public class EndMoveCommand : IMoveCommandEndable, ICommand
    {
        private IMovable _movableObject;
        private IInjectableCommand _injectableCommand;

        public void SetCommandParameters(ICommand moveCommand, UObject SpaceObject, Queue<ICommand> Queue)
        {
            _movableObject = new MovableAdapter(SpaceObject);
            _injectableCommand = (IInjectableCommand)Queue.First(x => x == moveCommand);
        }

        public void Execute()
        {
            _movableObject.Velocity = new SpaceVelocity(0, 0);
            _injectableCommand.Inject(new EmptyCommand());
        }
    }
}

namespace ServerLogic.Commands
{
    internal class MoveCommand : ICommand
    {
        private readonly IMovable _spaceObject;
        private readonly MoveAction _action;

        public MoveCommand(IMovable spaceObject)
        {
            _spaceObject = spaceObject;
            _action = new MoveAction();
        }

        public void Execute()
        {
            _action.Move(_spaceObject);
        }
    }
}

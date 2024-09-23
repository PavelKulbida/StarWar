namespace ServerLogic.Commands
{
    internal class BridgeCommand : IInjectableCommand, ICommand
    {
        private ICommand _command;

        public BridgeCommand(ICommand command)
        {
            _command = command;
        }

        public void Inject(ICommand command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();
        }
    }
}

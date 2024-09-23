namespace ServerLogic.Commands;

public interface IInjectableCommand
{
    void Inject(ICommand command);
}
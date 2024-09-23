namespace ServerLogic.Commands;

public interface IMoveCommandEndable
{
    void SetCommandParameters(ICommand moveCommand, UObject SpaceObject, Queue<ICommand> Queue);
}
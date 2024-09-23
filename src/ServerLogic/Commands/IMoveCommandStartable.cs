namespace ServerLogic.Commands;

public interface IMoveCommandStartable
{
    void SetCommandParameters(UObject SpaceObject, SpaceVelocity Velocity, Queue<ICommand> Queue);
}
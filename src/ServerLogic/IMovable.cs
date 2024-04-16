namespace ServerLogic;

public interface IMovable
{
    public SpacePoint Point { get; set; }

    public SpaceVelocity Velocity { get; set; }
}
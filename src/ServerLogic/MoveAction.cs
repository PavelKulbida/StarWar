namespace ServerLogic
{
    public class MoveAction
    {
        public void Move(IMovable moveItem)
        {
            ArgumentNullException.ThrowIfNull(moveItem);
            ArgumentNullException.ThrowIfNull(moveItem.Point);
            ArgumentNullException.ThrowIfNull(moveItem.Velocity);

            var currentPoint = moveItem.Point;

            var updatedX = currentPoint.X + moveItem.Velocity.X;
            var updatedY = currentPoint.Y + moveItem.Velocity.Y;
            moveItem.Point = new SpacePoint(updatedX, updatedY);

            if (moveItem.Point == currentPoint && moveItem.Velocity != new SpaceVelocity(0, 0))
            {
                throw new Exception("No-movable object");
            }
        }
    }
}

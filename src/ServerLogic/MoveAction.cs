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

            if (moveItem.Point == currentPoint)
            {
                throw new Exception("No-movable object");
            }
        }
    }
}

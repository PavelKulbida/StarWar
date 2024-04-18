namespace ServerLogic
{
    public class RotateAction
    {
        public void Rotate(IRotatable ratateItem)
        {
            ArgumentNullException.ThrowIfNull(ratateItem);
            ArgumentNullException.ThrowIfNull(ratateItem.Angle);
            ArgumentNullException.ThrowIfNull(ratateItem.AngleVelocity);

            var currentAngle = ratateItem.Angle;

            ratateItem.Angle += ratateItem.AngleVelocity;

            if (ratateItem.Angle == currentAngle && currentAngle != 0)
            {
                throw new Exception("No-rotatable object");
            }
        }
    }
}

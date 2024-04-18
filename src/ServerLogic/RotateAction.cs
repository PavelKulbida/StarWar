namespace ServerLogic
{
    public class RotateAction
    {
        public void Rotate(IRotatable rotateItem)
        {
            ArgumentNullException.ThrowIfNull(rotateItem);
            ArgumentNullException.ThrowIfNull(rotateItem.Angle);
            ArgumentNullException.ThrowIfNull(rotateItem.AngleVelocity);

            var currentAngle = rotateItem.Angle;

            rotateItem.Angle = currentAngle.Value + rotateItem.AngleVelocity.Value;

            if (rotateItem.Angle == currentAngle && currentAngle != 0)
            {
                throw new Exception("No-rotatable object");
            }
        }
    }
}

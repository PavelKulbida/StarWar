using ServerLogic;

namespace ServerLogicTests
{
    public class RotateActionTests
    {
        [Fact]
        public void RotateSuccessTest()
        {
            var spaceShip = new SpaceShip() { Angle = 45, AngleVelocity = 90 };
            var rotater = new RotateAction();

            rotater.Rotate(spaceShip);

            Assert.Equal(spaceShip.Angle, 135);
        }

        [Fact]
        public void RotateUnsuccessAngleTest()
        {
            var spaceShip = new SpaceShip() { Angle = null!, AngleVelocity = 90 }; ;
            var rotater = new RotateAction();

            var act = () => rotater.Rotate(spaceShip);

            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void RotateUnsuccessVelocityTest()
        {
            var spaceShip = new SpaceShip() { Angle = 45, AngleVelocity = null! }; ;
            var rotater = new RotateAction();

            var act = () => rotater.Rotate(spaceShip);

            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void RotateUnsuccessNoRotatableTest()
        {
            var spaceShip = new FakeSpaceShip(45, 90);
            var rotater = new RotateAction();

            var act = () => rotater.Rotate(spaceShip);

            Assert.Throws<Exception>(act);
        }

        public class FakeSpaceShip(int? angle, int? angleVelocity) : IRotatable
        {
            public int? Angle
            {
                get => angle;
                set {}
            }

            public int? AngleVelocity { get; } = angleVelocity;
        };
    }

}
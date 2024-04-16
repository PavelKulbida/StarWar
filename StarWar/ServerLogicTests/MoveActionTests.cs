using ServerLogic;

namespace ServerLogicTests
{
    public class MoveActionTests
    {
        [Fact]
        public void MoveSuccessTest()
        {
            var startPoint = new SpacePoint(12, 5);
            var velocity = new SpaceVelocity(-7, 3);
            var targetPoint = new SpacePoint(5, 8);
            var spaceShip = new SpaceShip() {Point = startPoint, Velocity = velocity};
            var mover = new MoveAction();

            mover.Move(spaceShip);

            Assert.Equal(spaceShip.Point, targetPoint);
        }

        [Fact]
        public void MoveUnsuccessPointTest()
        {
            var velocity = new SpaceVelocity(-7, 3);
            var spaceShip = new SpaceShip() { Velocity = velocity };
            var mover = new MoveAction();

            var act = () => mover.Move(spaceShip);

            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void MoveUnsuccessVelocityTest()
        {
            var startPoint = new SpacePoint(12, 5);
            var spaceShip = new SpaceShip() { Point = startPoint };
            var mover = new MoveAction();

            var act = () => mover.Move(spaceShip);

            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void MoveUnsuccessNoMovableTest()
        {
            var startPoint = new SpacePoint(12, 5);
            var velocity = new SpaceVelocity(-7, 3);
            var spaceShip = new FakeSpaceShip(startPoint, velocity);
            var mover = new MoveAction();

            var act = () => mover.Move(spaceShip);

            Assert.Throws<GameException>(act);
        }

        public class FakeSpaceShip(SpacePoint spaceShip, SpaceVelocity velocity) : IMovable
        {
            public SpacePoint Point
            {
                get => spaceShip;
                set { }
            }

            public SpaceVelocity Velocity { get; set; } = velocity;
        };
    }

}
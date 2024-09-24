using ServerLogic;
using ServerLogic.Commands;

namespace ServerLogicTests.Commands
{
    public class MovableAdapterTests
    {
        [Fact]
        public void AdapteeSuccessTest()
        {
            var id = Guid.NewGuid();
            var startPoint = new SpacePoint(0, 0);
            var initialVelocity = new SpaceVelocity(5, 5);
            var targetPoint = new SpacePoint(5, 5);
            var spaceShip = new SpaceShip() { Id = id, Point = startPoint, Velocity = initialVelocity };

            var adapter = new MovableAdapter(spaceShip);
            adapter.Point = targetPoint;

            Assert.Equal(adapter.Point, targetPoint);
            Assert.Equal(adapter.Velocity, initialVelocity);
        }
    }

}
using ServerLogic;
using ServerLogic.Commands;

namespace ServerLogicTests.Commands
{
    public class BridgeCommandTests
    {
        [Fact]
        public void ExecuteSuccessTest()
        {
            var id = Guid.NewGuid();
            var startPoint = new SpacePoint(0, 0);
            var initialVelocity = new SpaceVelocity(5, 5);
            var targetPoint = new SpacePoint(5, 5);
            var spaceShip = new SpaceShip() { Id = id, Point = startPoint, Velocity = initialVelocity };
            var commandMove = new MoveCommand(spaceShip);
            var commandNop = new EmptyCommand();
            var commandTest = new BridgeCommand(commandMove);

            commandTest.Execute();
            var actualPoint1 = spaceShip.Point;
            commandTest.Inject(commandNop);
            commandTest.Execute();
            var actualPoint2 = spaceShip.Point;

            Assert.Equal(actualPoint1, targetPoint);
            Assert.Equal(actualPoint2, targetPoint);
        }
    }

}
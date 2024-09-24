using ServerLogic;
using ServerLogic.Commands;

namespace ServerLogicTests.Commands
{
    public class StartMoveCommandTests
    {
        [Fact]
        public void ExecuteSuccessTest()
        {
            var id = Guid.NewGuid();
            var startPoint = new SpacePoint(12, 5);
            var initialVelocity = new SpaceVelocity(0, 0);
            var targetVelocity = new SpaceVelocity(5, 5);
            var spaceShip = new SpaceShip() { Id = id, Point = startPoint, Velocity = initialVelocity };
            var command = new StartMoveCommand();
            var commandQueue = new Queue<ICommand>();

            command.SetCommandParameters(spaceShip, targetVelocity, commandQueue);
            command.Execute();            
            
            Assert.Equal(spaceShip.Velocity, targetVelocity);
            Assert.NotEmpty(commandQueue);
        }
    }

}
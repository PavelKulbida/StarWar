using ServerLogic;
using ServerLogic.Commands;

namespace ServerLogicTests.Commands
{
    public class EndMoveCommandTests
    {
        [Fact]
        public void ExecuteSuccessTest()
        {
            var id = Guid.NewGuid();
            var startPoint = new SpacePoint(12, 5);
            var initialVelocity = new SpaceVelocity(5, 5);
            var startVelocity = new SpaceVelocity(10, 10);
            var targetVelocity = new SpaceVelocity(0, 0);
            var spaceShip = new SpaceShip() { Id = id, Point = startPoint, Velocity = initialVelocity };
            var commandQueue = new Queue<ICommand>();
            var commandStartMove = new StartMoveCommand();
            var commandTest = new EndMoveCommand();

            commandStartMove.SetCommandParameters(spaceShip, startVelocity, commandQueue);
            commandStartMove.Execute();
            var command = commandQueue.First();
            commandTest.SetCommandParameters(command, spaceShip, commandQueue);
            commandTest.Execute();            
            
            Assert.Equal(spaceShip.Velocity, targetVelocity);
        }
    }

}
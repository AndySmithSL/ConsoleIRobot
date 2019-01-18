using ConsoleIRobot.Interfaces;

namespace ConsoleIRobot.Classes
{
    public class MoveForwardOperation : IRobotOperation
    {
        public int NumberOfSteps { get; set; }

        public MoveForwardOperation(int numberOfSteps)
        {
            NumberOfSteps = numberOfSteps;
        }

        public void Replay(IRobot robot)
        {
            robot.MoveForward(NumberOfSteps);
        }
    }
}

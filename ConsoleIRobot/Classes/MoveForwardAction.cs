using ConsoleIRobot.Interfaces;

namespace ConsoleIRobot.Classes
{
    public class MoveForwardAction : IRobotAction
    {
        public int NumberOfSteps { get; set; }

        public MoveForwardAction(int numberOfSteps)
        {
            NumberOfSteps = numberOfSteps;
        }

        public void Replay(IRobot robot)
        {
            robot.MoveForward(NumberOfSteps);
        }
    }
}

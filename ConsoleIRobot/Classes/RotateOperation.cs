using ConsoleIRobot.Interfaces;

namespace ConsoleIRobot.Classes
{
    public class RotateOperation : IRobotOperation
    {
        public double Angle { get; set; }

        public RotateOperation(double angle)
        {
            Angle = angle;
        }

        public void Replay(IRobot robot)
        {
            robot.Rotate(Angle);
        }
    }
}

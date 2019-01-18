using ConsoleIRobot.Interfaces;

namespace ConsoleIRobot.Classes
{
    public class BeepOperation : IRobotOperation
    {
        public int NumberOfBeeps { get; set; }
        public double Volume { get; set; }

        public BeepOperation(int numberOfBeeps, double volume)
        {
            NumberOfBeeps = numberOfBeeps;
            Volume = volume;
        }

        public void Replay(IRobot robot)
        {
            robot.Beep(NumberOfBeeps, Volume);
        }
    }
}

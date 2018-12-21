using ConsoleIRobot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIRobot.Classes
{
    public class BeepAction : IRobotAction
    {
        public int NumberOfBeeps { get; set; }
        public double Volume { get; set; }

        public BeepAction(int numberOfBeeps, double volume)
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

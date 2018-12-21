using ConsoleIRobot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIRobot.Classes
{
    public class RotateAction : IRobotAction
    {
        public double Angle { get; set; }

        public RotateAction(double angle)
        {
            Angle = angle;
        }

        public void Replay(IRobot robot)
        {
            robot.Rotate(Angle);
        }
    }
}

using ConsoleIRobot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIRobot.Classes
{
    public class RobotRecorder: IRobotOperation
    {
        IRobot robot = null;

        public IRobot Robot { get => robot; set => robot = value; }

        public RobotRecorder(IRobot robot)
        {
            Robot = robot;
        }

        public void Replay(IRobot robot)
        {
            Robot = robot;
            Robot.repl
        }
    }
}

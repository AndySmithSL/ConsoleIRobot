using ConsoleIRobot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIRobot.Classes
{
    public class RobotRecorder
    {
        List<IRobotAction> actions = new List<IRobotAction>();



        void Replay(IRobot robot)
        {
            foreach (var item in actions)
            {
                item.Replay(robot);
            }
        }
    }
}

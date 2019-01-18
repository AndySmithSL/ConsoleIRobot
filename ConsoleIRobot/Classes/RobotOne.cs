using ConsoleIRobot.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleIRobot.Classes
{
    public class RobotOne : IRobot, IRobotOperation
    {
        List<IRobotOperation> actions = new List<IRobotOperation>();

        public void Beep(int numberOfBeeps, double volume)
        {
            Console.WriteLine("BEEP: {0} times @ volume {1}", numberOfBeeps, volume);
            actions.Add(new BeepOperation(numberOfBeeps, volume));
        }

        public void MoveForward(int numberOfSteps)
        {
            Console.WriteLine("MOVE: {0} steps @ volume {1}", numberOfSteps);
            actions.Add(new MoveForwardOperation(numberOfSteps));
        }

        public void Replay(IRobot robot)
        {
            foreach (var action in actions)
            {
                action.Replay(robot);
            }
        }

        public void Rotate(double angle)
        {
            Console.WriteLine("ROTATE: angle {0}", angle);
            actions.Add(new RotateOperation(angle));
        }
    }
}

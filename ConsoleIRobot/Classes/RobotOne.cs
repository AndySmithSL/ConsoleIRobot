using ConsoleIRobot.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleIRobot.Classes
{
    public class RobotOne : IRobot
    {
        List<IRobotAction> actions = new List<IRobotAction>();

        public void Beep(int numberOfBeeps, double volume)
        {
            Console.WriteLine("BEEP: {0} times @ volume {1}", numberOfBeeps, volume);


            actions.Add(new BeepAction(numberOfBeeps, volume));

        }

        public void MoveForward(int numberOfSteps)
        {
            Console.WriteLine("MOVE: {0} steps @ volume {1}", numberOfSteps);
        }

        public void Rotate(double angle)
        {
            Console.WriteLine("ROTATE: angle {0}", angle);
        }
    }
}

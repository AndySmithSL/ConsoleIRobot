namespace ConsoleIRobot.Interfaces
{
    public interface IRobot
    {
        void MoveForward(int numberOfSteps);
        void Rotate(double angle);
        void Beep(int numberOfBeeps, double volume);
    }
}

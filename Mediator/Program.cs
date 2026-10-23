namespace Mediator;

class Program
{
    static void Main(string[] args)
    {
        SmartHomeHub hub = new SmartHomeHub();

        MotionSensor motionSensor = new MotionSensor(hub);
        Window window = new Window(hub);

        motionSensor.DetectMotion();
        Console.WriteLine("--------------------------------------------------");
        window.Open();
        window.Close();
    }
}
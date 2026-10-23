namespace Mediator;

public class MotionSensor : Device
{

    public MotionSensor(IHomeMediator hub) : base(hub)
    {
        
    }

    public void DetectMotion()
    {
        _hub.Notify(this, "Motion detected");
        Console.WriteLine("Motion detected");
    }
}
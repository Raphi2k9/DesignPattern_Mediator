namespace Mediator;

public class Heating : Device
{

    public Heating(IHomeMediator hub) : base(hub)
    {
        
    }

    public void TurnOn()
    {
        _hub.Notify(this, "Heating turned on");
        Console.WriteLine("Heating turned on");
    }
    public void TurnOff()
    {
        _hub.Notify(this, "Heating turned on");
        Console.WriteLine("Heating turned off");
    }
}
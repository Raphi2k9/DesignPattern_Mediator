namespace Mediator;

public class Light : Device
{

    public Light(IHomeMediator hub) : base(hub)
    {
        
    }
    
    public void TurnOn()
    {
        Console.WriteLine("Light turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("Light turned off");
    }
}
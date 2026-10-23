namespace Mediator;

public class Window : Device
{

    public Window(IHomeMediator hub) : base(hub)
    {
        
    }

    public void Open()
    {
        _hub.Notify(this, "Window opened");
        Console.WriteLine("Window opened");
    }
    
    public void Close()
    {
        _hub.Notify(this, "Window closed");
        Console.WriteLine("Window closed");
    }
}
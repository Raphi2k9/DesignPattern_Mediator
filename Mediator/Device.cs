namespace Mediator;

public abstract class Device
{
    protected IHomeMediator _hub;
    
    public Device(IHomeMediator hub)
    {
        _hub = hub;
    }
}
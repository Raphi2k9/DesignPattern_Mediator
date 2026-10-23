namespace Mediator;

public interface IHomeMediator
{
    public void Notify(Device d, String eventName);
}
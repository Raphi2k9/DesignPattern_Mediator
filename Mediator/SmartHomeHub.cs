namespace Mediator;

public class SmartHomeHub : IHomeMediator
{
    private MotionSensor _motionSensor;
    private Light _light;
    private Window _window;
    private Heating _heating;
    public SmartHomeHub()
    {
        _motionSensor = new MotionSensor(this);
        _light = new Light(this);
        _window = new Window(this);
        _heating = new Heating(this);
    }

    public void Notify(Device d, String eventContent)
    {
        if (d is MotionSensor && eventContent == "Motion detected")
        {
            _light.TurnOn();
        }
        if (d is Window && eventContent == "Window opened")
        {
            _heating.TurnOff();
        }
        if (d is Window && eventContent == "Window closed")
        {
            _heating.TurnOn();
        }
    }
}
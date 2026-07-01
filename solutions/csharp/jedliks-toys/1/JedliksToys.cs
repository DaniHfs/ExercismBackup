class RemoteControlCar
{
    private int _distanceDriven;
    private int _batteryLevel = 100;
    
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() =>
        $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => _batteryLevel is 0
        ? "Battery empty"
        : $"Battery at {_batteryLevel}%";

    public void Drive()
    {
        if (_batteryLevel is 0) return;

        _distanceDriven += 20;
        _batteryLevel -= 1;

        return;
    }
}

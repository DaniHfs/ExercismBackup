static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
            0 => 0.00,
            >= 1 and <= 4 => 1.00,
            >=5 and <=8 => 0.90,
            9 => 0.80,
            10 => 0.77,
            _ => 0.00
    };

    public static double ProductionRatePerHour(int speed)
    {
        return (221.0 * speed) * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }
}

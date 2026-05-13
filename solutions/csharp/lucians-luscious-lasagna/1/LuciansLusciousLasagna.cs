class Lasagna
{
    // How many minutes the lasagna should be in the oven
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // How many minutes the lasagna has left in the oven
    public int RemainingMinutesInOven(int elapsedMinutesInOven)
    {
        return ExpectedMinutesInOven() - elapsedMinutesInOven;
    }
    // How many minutes spent preparing the lasagna
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int elapsedMinutesInOven)
    {
        return PreparationTimeInMinutes(layers) + elapsedMinutesInOven; 
    }
}

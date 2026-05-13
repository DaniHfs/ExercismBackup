static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (!knightIsAwake)
            return true;
        else
            return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
            return false;
        else
            return true;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        => !archerIsAwake && prisonerIsAwake;


    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool withDog = petDogIsPresent && !archerIsAwake;
        bool withoutDog = !petDogIsPresent && !archerIsAwake && !knightIsAwake && prisonerIsAwake;

        return withDog || withoutDog;
    }
}

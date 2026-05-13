public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splitNumber = phoneNumber.Split('-');

        bool IsNewYork = splitNumber[0] == "212";
        bool IsFake = splitNumber[1] == "555";
        string LocalNumber = splitNumber[2];

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        => phoneNumberInfo.IsFake;
}

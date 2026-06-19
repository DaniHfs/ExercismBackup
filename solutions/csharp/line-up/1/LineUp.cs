public static class LineUp
{
    public static string Format(string name, int number)
    {        
        int lastTwoDigits = number % 100;
        int lastDigit = number % 10;

        if (number == 0)
            return "No customers to serve";

        if (number > 999)
            return "Too many customers to serve";
        
        string suffix = (lastTwoDigits, lastDigit) switch
        {
                (11 or 12 or 13, _) => "th",
                (_, 1)              => "st",
                (_, 2)              => "nd",
                (_, 3)              => "rd",
                _                   => "th"
        };

        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
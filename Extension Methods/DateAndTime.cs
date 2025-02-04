public static class DateAndTimeExtension
{
    public static int GetCurrentAge(this DateTime birthDate)
    {
        var Today = DateTime.Today;
        if(birthDate > Today)
        {
            throw new ArgumentException("Invalid Date of Birth.");
        }
        var myAge = Today.Year - birthDate.Year;  
        return myAge;
    }
} 
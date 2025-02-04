class Program
{
    public static void Main(string[] args)
    {
        string Text = "My name is Nirmal";
        Console.WriteLine($"the reverse of the text: {Text} is=> {Text.ReverseString()}");
        Console.WriteLine($"Title Case: {Text.ToUpperCase()}");
        Console.WriteLine($"Returns Vowels: {Text.extractVowels()}");

        DateTime dateOfBirth = new DateTime(2003, 08, 07);
        int age = dateOfBirth.GetCurrentAge();
        Console.WriteLine($"Date Of Birth: {dateOfBirth.ToShortDateString()}. I am {age} years old.");
    }
}
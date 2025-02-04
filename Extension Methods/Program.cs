class Program
{
    public static void Main(string[] args)
    {
        string Text = "My name is Nirmal";
        Console.WriteLine($"the reverse of the text: {Text} is=> {Text.ReverseString()}");
        Console.WriteLine($"Title Case: {Text.ToUpperCase()}");
        Console.WriteLine($"Returns Vowels: {Text.extractVowels()}");
    }
}
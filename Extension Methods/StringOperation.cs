using System;
using System.Text; 
public static class StringExtensions{
    // To find the reverse of the string
    public static string ReverseString(this string input){
        if(string.IsNullOrEmpty(input))
        {
            return input;
        }
        
        StringBuilder reverseString = new StringBuilder();

        for(int i = input.Length -1; i>=0; i--)
        {
            reverseString.Append(input[i]);
        }  
        return reverseString.ToString();
    }
    //To convert the Text Into Upper case
    public static string ToUpperCase(this string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return input;
        }
        return char.ToUpper(input[0]) + input.Substring(1);
    }
    //To get vowels in a string 
    public static string extractVowels(this string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return input;
        }
        StringBuilder vowels = new StringBuilder();
        var vowelsChar = "aeiouAEIOU";
        foreach(var str in input)
        {
            if(vowelsChar.Contains(str))
            {
                vowels.Append(str);
            }
        }
        return vowels.ToString();
    }
}
using System;
using System.Text;
namespace StringBuilderTask
{
    public static class SentenceMaker
    {
        public static string CreateSentence(this string[] words)
        {
            StringBuilder sentence = new StringBuilder();
            foreach(var word in words)
            {
                sentence.Append(word+ " ");
            }
            return sentence.ToString().TrimEnd();
        }
        public static string CommaSeparatedString(this string[] names)
        {
            if(names == null || names.Length == 0){
                return string.Empty;
            }
            StringBuilder sentence = new StringBuilder();
            for(int i = 0; i< names.Length; i++){
                sentence.Append(names[i]);
                if(i< names.Length -1)
                {
                    sentence.Append(", ");
                }
            }
            return sentence.ToString();
        }
        class Program
        {
            public static void Main(string[] args) 
            {
                string[] words = {"Hello","My","name","is","Nirmal","muni","Bajracharya"};
                string[] names = {"Ravi","Ram","Kumar","Suraj","Hemant","Binod"};
                var sentence = words.CreateSentence();
                Console.WriteLine(sentence);
                Console.WriteLine(names.CommaSeparatedString());
            }
        }
    }
}
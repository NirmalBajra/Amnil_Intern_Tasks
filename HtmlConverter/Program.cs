﻿using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

class MdToHtmlConverter{
    public static void Main(string[] args){
        string filePath = "Markdown.md"; //md file path

        try{
           var mdFileContent = File.ReadAllText(filePath); 
           StringBuilder html = new StringBuilder();
           string[] lines = mdFileContent.Split(new[] {'\n'}); //spliting the files when '\n'
           bool inList = false;
           bool inCodeBlock = false;

           foreach(string line in lines)
           {
            string trimmedLine = line.Trim();
            Match headingMatch = Regex.Match(trimmedLine, @"^(#{1,6})\s+(.+)");
            
            //To Create Headings 
            if(headingMatch.Success)
            {
                int level = headingMatch.Groups[1].Value.Length; // counting number of #
                string headingText = headingMatch.Groups[2].Value; // extracting the content of the headings
                html.AppendFormat("<h{0}>{1}</h{0}>\n",level,headingText);
                continue;
            }

            //For Paragraphs
            if(!string.IsNullOrWhiteSpace(trimmedLine))
            {
                html.AppendFormat("<p>{0}</p>\n",trimmedLine);
                continue;
            }

            // handling Horizontal Rules (--- or *** )
            if(Regex.IsMatch(trimmedLine, @"^[-*]{3,}$"))
            {
                html.AppendFormat("<hr />");
                continue;
            }

            //handling Emphasis Bold Or Italic
            trimmedLine = Regex.Replace(trimmedLine, @"\*\*(.+?)\*\*", "<strong>$1</strong>"); // converting to Bold Text
            trimmedLine = Regex.Replace(trimmedLine, @"\*(.+?)\*", "<em>$1</em>") ; // converting into itallic text
            html.AppendLine(trimmedLine);

            //For Blockqutes

            if(trimmedLine.StartsWith(">")){
                html.AppendFormat("<blockquote>{0}</blockquote> \n", trimmedLine.Substring(1).Trim());
            }

           }
        string htmlFilePath = "output.html";
        File.WriteAllText(htmlFilePath, html.ToString());
        Console.WriteLine($"Html page created Successfully in {htmlFilePath}");
        }
        catch(Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
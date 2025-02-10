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
           bool inOrderedList = false;
           bool inCodeBlock = false;
           bool lastLineWasEmpty = true;

           foreach(string line in lines)
           {
            string trimmedLine = line.Trim();

            // Handling Code Blocks (``` ... ```)
            if(trimmedLine.StartsWith("```")){
                inCodeBlock = !inCodeBlock;
                html.AppendLine(inCodeBlock ? "<pre><code>" : "</code></pre>");
                continue;
            }
            if(inCodeBlock){
                html.AppendLine(trimmedLine);
                continue;
            }

            Match headingMatch = Regex.Match(trimmedLine, @"^(#{1,6})\s+(.+)");

            //To Create Headings (#h1, ##h2, ... )
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
                html.AppendLine("<hr />");
                continue;
            }

            //handling Emphasis Bold Or Italic
            trimmedLine = Regex.Replace(trimmedLine, @"\*\*(.+?)\*\*", "<strong>$1</strong>"); // converting to Bold Text
            trimmedLine = Regex.Replace(trimmedLine, @"\*(.+?)\*", "<em>$1</em>") ; // converting into itallic text
            html.AppendLine(trimmedLine);

                // Handling Lists
                Match unorderedListMatch = Regex.Match(trimmedLine, @"^[-*]\s+(.+)");
                Match orderedListMatch = Regex.Match(trimmedLine, @"^\d+\.\s+(.+)");

                if (unorderedListMatch.Success)
                {
                    if (!inList)
                    {
                        html.AppendLine("<ul>");
                        inList = true;
                    }
                    html.AppendFormat("<li>{0}</li>\n", unorderedListMatch.Groups[1].Value);
                    continue;
                }
                else if (orderedListMatch.Success)
                {
                    if (!inOrderedList)
                    {
                        html.AppendLine("<ol>");
                        inOrderedList = true;
                    }
                    html.AppendFormat("<li>{0}</li>\n", orderedListMatch.Groups[1].Value);
                    continue;
                }
                else
                {
                    if (inList)
                    {
                        html.AppendLine("</ul>");
                        inList = false;
                    }
                    if (inOrderedList)
                    {
                        html.AppendLine("</ol>");
                        inOrderedList = false;
                    }
                }

            
             // Handling Line Breaks ( `<br>`, and `\`)
                trimmedLine = Regex.Replace(trimmedLine, @"  $", "<br>"); // Double spaces -> <br>
                trimmedLine = Regex.Replace(trimmedLine, @"\\$", "<br>"); // Backslash -> <br>

            //For Blockqutes

            if (trimmedLine.StartsWith(">"))
                {
                    html.AppendFormat("<blockquote>{0}</blockquote>\n", trimmedLine.Substring(1).Trim());
                    continue;
                }

            // Handling Images
                trimmedLine = Regex.Replace(trimmedLine, @"!\[(.*?)\]\((.*?)\)", "<img src=\"$2\" alt=\"$1\">");

            // Handling Links
            trimmedLine = Regex.Replace(trimmedLine, @"\[(.*?)\]\((.*?)\)", "<a href=\"$2\">$1</a>");

           }
            // Closing any open list tags at the end 
            if (inList) html.AppendLine("</ul>");
            if (inOrderedList) html.AppendLine("</ol>");
        string htmlFilePath = "output.html";
        File.WriteAllText(htmlFilePath, html.ToString());
        Console.WriteLine($"Html page created Successfully in {htmlFilePath}");
        }
        catch(Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
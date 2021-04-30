using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                Console.WriteLine(text);
                return text;
            }
            var words = text.Split(' ');
            var totalChars = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalChars += word.Length + 1; //adds word to list
                if (totalChars > maxLength) //if true and list is over maxLength, list still retains previously added word.
                {
                    break;
                }
            }
            return String.Join(" ", summaryWords) + "..."; ;
        }

    }
}

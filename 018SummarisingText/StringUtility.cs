using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018SummarisingText
{
    public class StringUtility
    {

        public static string SummerizeText(string text, int maxLength = 20)
        {

            /*if text short enough, we will display it directly, otherwise we will summarise it*/
            if (text.Length < maxLength)
            {

                return text;
            }
            else
            {
                // sentence.Substring(0, maxLength); /*if we use in this way, we may cut the word on half, so it is not good way*/
                var words = text.Split(' '); /*so, we are going to split all words as an array element*/
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words) /* find total count of length each time, and check if it is long enough*/
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1; /*we also add 1 because of whitespaces*/
                    if (totalCharacters > maxLength)
                        break;

                }

                return String.Join(" ", summaryWords) + "..."; //if we already finished what we have done, make new string with join;
            }
        }

    }
}

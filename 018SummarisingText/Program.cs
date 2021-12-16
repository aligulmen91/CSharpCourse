using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018SummarisingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really long text to use in summarising example.";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);
        }

       
    }
}

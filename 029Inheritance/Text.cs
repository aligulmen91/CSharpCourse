using System;

namespace _029Inheritance
{
    public class Text : PresentationObject /*  : PresentationObject is implementing the code from another class*/
    {
        //code specific to Text
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to " + url );
        }
    }
}

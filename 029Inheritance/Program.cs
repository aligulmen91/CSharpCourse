using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*inheritnance is a kind of a relationship between two classes that allows one to inherit code from the other*/
            /* code re-use */
            /* for example in paint there are height and width for all shapes, and we dont want to repeat all of them, we create one and use for all */

            var text = new Text();
            text.Width = 100;   /* Normally width class belongs to presentationObject class, but because of we use inheritance, we can use with Text class too */
            text.Copy();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036AbstractClassesMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

}
/*Ok, we define virtual method and we override from circle method, everything seems good
       But the problem is we can not draw a shape?!?! We can draw a circle, we can draw a rectangle but shape???
      We will use code modifiers. 
      For code modifiers, we won't use virtual, we will use abstract. it doesn't have body, it is just declearation
      You can just use this when you don't have implementation. When you do not have body...
      and you can not instantiated shape now. because of it is abstract
      var shape = new Shape(); won't compile!!
But why we use this method?????!!!???
Ok, let's say it is virtual and not abstract. we override circle class. it is working good.
But sometime later, we create a class as rectangle ve derived it to shape BUT WE FORGOT TO OVERRIDE IT..
IT WONT GIVE ERROR; BUT IT WONT WORK TOO... so if we want to push developers to write their code without an error
it is better to use abstract
 */
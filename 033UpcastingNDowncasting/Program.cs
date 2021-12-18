using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033UpcastingNDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Text text = new Text();
            Shape shape = text; //this is upcasting  text -> shape

            text.FontSize = 45;
            text.Width = 200;
            shape.Width = 100; /*we dont have some properties like fontsize here, even they are same, it is limited*/

            Console.WriteLine(text.Width); /*we got 100 because they are same object!! */


            /*But why we use it? why we need same object with upcasting? Lets look an example*/
            /*from view > object browser, you can see what is filestream and how you can use it*/
           // StreamReader reader = new StreamReader(new MemoryStream()); //this is upcasting..
           var list = new ArrayList();
            list.Add(1);
            list.Add("Ali");
            list.Add(new Text()); /*we can add whatever we want as an object, string, integer, shape etc..*/
            /*but the problem is when we try to convert list to another type, we will get an error. so better to use generic list*/

            var anotherlist = new List<int>(); //this list is generic list, we can only add integer values, more safe
            var anotherlist2 = new List<Shape>(); //this list is generic list, we can only add shape values, more safe
            /*this is also upcasting. generic list -> list*/


            /*Downcasting Examples*/
           
            Shape shape2 = new Text();
            /*Although it is shape type, in runtime it will be type text
             but when we try to see fontsize, we can not, because it is shape...
            so we need to downcast , in this way we can reach that properties
            
             */
            Text text2 = (Text)shape2; //now we can reach all properties that text has

        }
    }
}
/*
   Conversion from a derived class to a base class (upcasting)
  Conversion from a base class to a derived class (downcasting)

   */

/*
  Circle circle = new Circle();
  Shape shape = circle;  //this is upcasting. no need to convert anything. we can directly define it. from down class to derived class
*/

/*Circle anotherCircle = (Circle)shape; //this is downcasting. We convert the derived class to down class*/
//Car car = (Car)shape; //not possible. because it is not derived, throws InvalidCastException
/*There is safe way to control this Exception*/

/*
Car car = (Car)obj; //dont use like this

car car = obj as Car; //use with "as" like this . if it is not possible to convert, it wont throw an exception
if(car != null)
{
    ....
}


//to check the type of an object...
if (obj is Car){    //this is also useful way
Car car = (Car) obj; 
}
*/
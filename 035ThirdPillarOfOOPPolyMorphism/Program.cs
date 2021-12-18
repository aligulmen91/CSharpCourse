using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035ThirdPillarOfOOPPolyMorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var shapes = new List<Shape>();
            shapes.Add(new Circle { Width =100, Height =100 });
            shapes.Add(new Rectangle { Width = 100, Height = 30 });

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }




}

/*
 Method Overriding : modifying the implementation of an inherited method.
ok, lets talk about a small example.
for shape, we have different drawing properties for circle and image,
so we need to modify drawing method.
BUT HOW?
first of all we should define virtual void Draw() as method, in this way we will tell it is ready to be modified, we have defaults
and ready to add new things for every class
and when we are going to use it in another class , use override void Draw() for this method it will run all of the default and more,
it will do whatever we add in this method
 */

/*
 OK, now lets work with the sample code. This code has some mistakes,
because everytime we need to add shapetype, we should go canvas and add new case,
then we affect all the codes.. this is not good!
The reason is, properties are in shape class but behavior are in shape types. and this is not right way.
So we need to encapsulate them!
First of all lets create class Circle and derived to shape class
and make it virtual to give different behaviour in other classes like rectangular triangle or circle
 */
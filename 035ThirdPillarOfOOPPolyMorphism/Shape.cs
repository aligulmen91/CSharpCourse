namespace _035ThirdPillarOfOOPPolyMorphism
{

    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle");
        }

       
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectangle");
        }
    }


    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
    



        public virtual void Draw()
        {
            //Here is the default implementation, for circle, rectangle, triangle, whatever so, it is virtual
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
 */
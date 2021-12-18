using System.Collections.Generic;

namespace _035ThirdPillarOfOOPPolyMorphism
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
               shape.Draw(); // when we call this it will depend on shape, we will call circle or we will call rectangular
                            // this is polymorphism. More simple and more readable
            }
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
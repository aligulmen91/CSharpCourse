namespace _033UpcastingNDowncasting
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
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
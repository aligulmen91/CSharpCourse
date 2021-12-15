namespace _011ConditionalExercises
{
    internal partial class Program
    {
        public class Exercise3
        {
            /*
            Write a program and ask the user to enter 
            the width and height of an image. 
            Then tell if the image is landscape or portrait.
             */

            public static string isLandscape(string pwidth, string pheight)
            {
                string ptype = "Landscape";
                ptype = (int.Parse(pwidth) > int.Parse(pheight)) ? "Landscape" : "Portrait";
                return ptype;
            }
        }

    }
}

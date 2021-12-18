using System;

namespace _036AbstractClassesMembers
{
    public abstract class Shape
    {
       
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();

        //public virtual void Draw()
        //{
        //}

        public void Copy()
        {
            Console.WriteLine("Copy Shape into clipboard");
        }
    }

}
 
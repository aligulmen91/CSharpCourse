using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047Dynamics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*in static*/
            object obj = "Ali";
            obj.GetType();

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);
            
            /*in dynamic*/
            dynamic excelObject = "Ali";
            excelObject.Optimize();

            /*because of we define dynamic, we can change type of variable*/
            dynamic name = "Ali";
            name = 10;
        }
    }
}
/*
 
 Static languages : C# , Java
Dynamically-typed languages : JS, Python

static languages, resolution of types at compile-time : early feedback
dynamic languages : at run-time. Easier and faster to code
 
COM, IronPython : Dynamic type in C#
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter; /*developer can use their new filter*/

                processor.Process("image.jpg",filterHandler);
        }

        /*now developer can define new filters here, we don't need to recompile our dll everytime*/
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("RemoveRedEye Applied");
        }
    }


  
    
}

/*Delegate : an object that knows how to call a method or group of methods
 *for designing extensible and flexible applications frameworks
 *
 
 
 
 for example this is not extensible code, 
lets say one of the developer want to apply a new filter that we haven't defined
we have to create new filter, and recompile then redeploy.
And imagine we do it everytime.
With delegate we can make code extensible

 We can use interfaces instead of delegates
if the caller doesnt need to access other properties or methods on the object implementing the method use delegates
 */
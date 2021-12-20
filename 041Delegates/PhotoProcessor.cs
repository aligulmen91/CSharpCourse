namespace _041Delegates
{
    public class PhotoProcessor
    {

        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path,PhotoFilterHandler filterHandler){
            var photo = Photo.Load(path);
           
            filterHandler(photo); /*coming with delegate*/

            photo.Save();
    }

    }
}

/*Delegate : an object that knows how to call a method or group of methods
 *for designing extensible and flexible applications frameworks 
 
 
  first we will define delegate type
    public delegate void PhotoFilterHandler(Photo photo);
    to make extensible, instead of we hardcoding every filter, we will take them
 
 */

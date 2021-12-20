namespace _041Delegates
{
    public class PhotoFilters
    {
      

            public void ApplyBrightness(Photo photo)
            {
                System.Console.WriteLine("Brightness applied");
            }

        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Contrast applied");
        }

        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Photo resized");
        }
    }
    }

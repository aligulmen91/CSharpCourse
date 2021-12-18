namespace _030Composition
{
    internal partial class Program
    {
        public class Installer
        {
            private readonly Logger _logger;


            public Installer(Logger logger)
            {
                _logger = logger;

            }
            public void Install()
            {
                _logger.Log("The Installation message");
            }
        }
    }
}

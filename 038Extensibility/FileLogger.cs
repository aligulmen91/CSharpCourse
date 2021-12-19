using System.IO;


namespace _038Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path; /*we take the path in constructor*/
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");

        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }

        public void LogWarning(string message)
        {
            Log(message, "Warning");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true)) { 
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}

/*The perfect code means, if you want to change anything in the future, you shouldn't change anything inside code,
 you should add new classes and you don't touch existing code. And this is Extensibility

 For example, instead of using Console.Writeline (maybe we will log messages to a file) we use loggers*/

/*Now, it is logging to console. lets say that we want to log in a file,  we wont touch anything from outside
 we will just create new class FileLogger*/
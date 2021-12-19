using System;

namespace _038Extensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
    }
}

/*The perfect code means, if you want to change anything in the future, you shouldn't change anything inside code,
 you should add new classes and you don't touch existing code. And this is Extensibility

 For example, instead of using Console.Writeline (maybe we will change the messages in the future) we use loggers*/
/*To use interface, we create constructor and we call Interface*/
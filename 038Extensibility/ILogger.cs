namespace _038Extensibility
{
    public interface ILogger /*we create interface to show messages instead of console write*/
    {
        void LogError(string message);
        void LogWarning(string message);
        void LogInfo(string message);
    }
}

/*The perfect code means, if you want to change anything in the future, you shouldn't change anything inside code,
 you should add new classes and you don't touch existing code. And this is Extensibility

 For example, instead of using Console.Writeline (maybe we will change the messages in the future) we use loggers*/
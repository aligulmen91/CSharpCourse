using System;

namespace _048ExceptionHandling
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message,Exception innerException)
            : base(message, innerException)
        {
            
        }
    }
}
/*
 sometimes you want to create custom exception
with this way you can do it. you can create new exception and base to main method
 */
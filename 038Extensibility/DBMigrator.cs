using System;

namespace _038Extensibility
{
    /*now, there is nothing about the other classes, just interfacec and our objects*/
    public class DbMigrator
    {

/*Here is our constructor to use interface(dependency injection)*/
        private readonly ILogger _logger;

         public DbMigrator(ILogger logger)
            {
            _logger = logger;
            }



        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished at " + DateTime.Now);
            
            //Console.WriteLine("Migration started at {0}", DateTime.Now);
            
            //Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }
}

/*The perfect code means, if you want to change anything in the future, you shouldn't change anything inside code,
 you should add new classes and you don't touch existing code. And this is Extensibility

 For example, instead of using Console.Writeline (maybe we will change the messages in the future) we use loggers*/
/*To use interface, we create constructor and we call Interface*/
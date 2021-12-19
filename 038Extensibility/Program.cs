using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _038Extensibility
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"Log.txt"));
            
            dbMigrator.Migrate();
        }
    }
}

/*The perfect code means, if you want to change anything in the future, you shouldn't change anything inside code,
 you should add new classes and you don't touch existing code. And this is Extensibility

 For example, instead of using Console.Writeline (maybe we will log messages to a file) we use loggers*/

/*Now, it is logging to console. lets say that we want to log in a file,  we wont touch anything from outside
 we will just create new class FileLogger*/
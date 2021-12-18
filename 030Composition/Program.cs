using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030Composition
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            /*the main thing is we create logger class and we used it in another classes*/
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}

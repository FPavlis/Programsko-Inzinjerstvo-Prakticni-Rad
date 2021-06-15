using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace ObavijestiService
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<Obavijesti>(s =>
                {
                    s.ConstructUsing(obavijest => new Obavijesti());
                    s.WhenStarted(obavijest => obavijest.Start());
                    s.WhenStopped(obavijest => obavijest.Stop());
                });


                x.RunAsLocalSystem();

                x.SetServiceName("ObavijestService");
                x.SetDisplayName("Obavijest Service");
                x.SetDescription("Ovaj service šalje email za obavijesti svaki dan ako postoji obavijest za sljedeći dan");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}

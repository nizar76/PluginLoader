using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace ClassLibrary2
{
    public class SecondCommand : ICommand
    {
        public string Name { get; }

        public SecondCommand()
        {
            Name = "SecondCommand";
        }

        public void run()
        {
            Console.WriteLine("Do SecondCommand");
        }
    }
}

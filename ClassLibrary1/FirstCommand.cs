using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FirstCommand : ICommand
    {
        public string Name { get; }

        public FirstCommand()
        {
            Name = "FirstCommand";
        }

        public void run()
        {
            Console.WriteLine("Do FirstCommand");
        }
    }
}

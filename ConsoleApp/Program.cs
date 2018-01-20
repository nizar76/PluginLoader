using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string LibFolder = Directory.GetCurrentDirectory() + @"\Lib\";

            ICommand [] cmds = PluginLoader.GetInterfaceImplementor<ICommand>(LibFolder);

            foreach(ICommand cmd in cmds)
            {
                Console.WriteLine(cmd.Name);
                cmd.run();
            }
			
            Console.ReadKey();
        }
    }
}

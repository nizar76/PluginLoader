using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleApp
{
    public class PluginLoader
    {
        public static T[] GetInterfaceImplementor<T>(string directory)
        {
            if (String.IsNullOrEmpty(directory)) { return null; } //sanity check

            DirectoryInfo info = new DirectoryInfo(directory);
            if (!info.Exists) { return null; } //make sure directory exists

            var implementors = new List<T>();

            foreach (FileInfo file in info.GetFiles("*.dll")) //loop through all dll files in directory
            {
                Assembly currentAssembly = null;
                try
                {
                    var name = AssemblyName.GetAssemblyName(file.FullName);
                    currentAssembly = Assembly.Load(name);
                }
                catch (Exception)
                {
                    continue;
                }

                currentAssembly.GetTypes()
                    .Where(t => t != typeof(T) && typeof(T).IsAssignableFrom(t))
                    .ToList()
                    .ForEach(x => implementors.Add((T)Activator.CreateInstance(x)));
            }
            return implementors.ToArray();
        }
    }
}

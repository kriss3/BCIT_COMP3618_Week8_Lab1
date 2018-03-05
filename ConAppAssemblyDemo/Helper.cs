using System.Reflection;
using static System.Console;

namespace ConAppAssemblyDemo
{
    public static class Helper
    {
        /// <summary>
        /// BCIT COMP3618 Week 8 Lab 1
        /// Krzysztof Szczurowski
        /// Repo: https://github.com/kriss3/BCIT_COMP3618_Week8_Lab1.git
        /// Helper class containing static methods used in the main app;
        /// </summary>
        /// <param name="a"></param>
        public static void ShowAssemblyInfo(Assembly a)
        {
            WriteLine(a.FullName);
            WriteLine("From GAC? {0}", a.GlobalAssemblyCache);
            WriteLine("Path: {0}", a.Location);
            WriteLine("Version: {0}", a.ImageRuntimeVersion);
            
            // Show Modules
            foreach (Module m in a.GetModules())
            {
                WriteLine(" Mod: {0}", m.Name);
            }
        }
    }
}

using System.Reflection;
using static System.Console;

namespace ConAppAssemblyDemo
{
    public static class Helper
    {
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

using System.Reflection;
using static System.Console;

namespace ConAppAssemblyDemo
{
    class MyApp
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.dll";
            // Load a specific Assembly
            Assembly a = Assembly.LoadFile(path);
            Helper.ShowAssemblyInfo(a);
            // Get our Assembly
            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            Helper.ShowAssemblyInfo(ourAssembly);
            Read();
        }
    }
}

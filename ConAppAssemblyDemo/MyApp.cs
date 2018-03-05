using System.Reflection;
using static System.Console;

namespace ConAppAssemblyDemo
{
    class MyApp
    {
        /// <summary>
        /// BCIT COMP3618 Week 8 Lab 1
        /// Krzysztof Szczurowski
        /// Repo: https://github.com/kriss3/BCIT_COMP3618_Week8_Lab1.git
        /// Main application entry point;
        /// </summary>
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

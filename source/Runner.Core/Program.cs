using System;
using fitSharp.IO;
using fitSharp.Machine.Application;

namespace Runner
{
    class Program
    {
        static int Main(string[] arguments)
        {
            return new Shell(new ConsoleReporter(), new ShellArguments(new FileSystemModel(), arguments)).Run();
        }
    }
}

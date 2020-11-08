using System;
using CmdLine.DataAccess;

namespace CmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.RunMigrations();

            Console.WriteLine("Hello World!");
        }
    }
}

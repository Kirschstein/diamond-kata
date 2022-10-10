using System;

namespace Diamond // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var row in Diamond.GetLines(args[0]))
            {
                Console.WriteLine(row);
            }
        }
    }
}
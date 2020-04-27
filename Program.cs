using System;


namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Gray;
           
            /* Hello, world program
               This program writes “hello, world” to the console
            */
            Console.WriteLine("Hello Word");

            Console.ResetColor();
            Console.WriteLine("Hello Word");

            float t = 28;
            Console.WriteLine(t);
            // HACK: убарть нах
            Console.ReadKey();


        }
    }
}

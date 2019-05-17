using System;

namespace Mid_HIMRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            var terminal = new Terminal();
            terminal.Run();

            Console.WriteLine("\n\n-----------------------------------");
            Console.WriteLine("End of demo. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

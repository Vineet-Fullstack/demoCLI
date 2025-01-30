using System;
namespace demoCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Demo CLI Tool\nUsage: democli <command>");
                return;
            }

            string command = args[0].ToLower();

            switch (command)
            {
                case "hello":
                    Console.WriteLine("Hello, welcome to Demo CLI!");
                    break;
                case "version":
                    Console.WriteLine("Demo CLI Tool v1.0.0");
                    break;
                default:
                    Console.WriteLine($"Unknown command: {command}");
                    break;
            }
        }
    }
}
using System;
using System.Threading;

namespace studioTeam
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Black X Tech!");



           
                Console.WriteLine();
                Console.WriteLine("\nStarting animation...\n");

                // Frame 1
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    |");
                Thread.Sleep(200);

                // Frame 2
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    /");
                Thread.Sleep(200);

                // Frame 3
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    -");
                Thread.Sleep(200);

                // Frame 4
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    \\");
                Thread.Sleep(200);

                // Frame 5
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    |");
                Thread.Sleep(200);

                // Frame 6
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    /");
                Thread.Sleep(200);

                // Frame 7
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    -");
                Thread.Sleep(200);

                // Frame 8
                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation Frame:");
                Console.WriteLine("    \\");
                Thread.Sleep(200);

                Console.Clear();
                Console.WriteLine("Hello, Welcome to Black X Tech!");
                Console.WriteLine("\nAnimation complete!");
         


            Console.WriteLine("That was the simplest way of writing code for animation above");
            Console.WriteLine("Now, let's do the same animation using loops for better efficiency.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();

            // ASCII Animation - Spinning Wheel (8 frames)
            string[] frames = {
                "|",
                "/",
                "-",
                "\\",
                "|",
                "/",
                "-",
                "\\"
            };
            
            Console.WriteLine("\nStarting animation...\n");
            
            // Run animation for 5 complete cycles
            for (int cycle = 0; cycle < 5; cycle++)
            {
                for (int i = 0; i < frames.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Hello, Welcome to Black X Tech!");
                    Console.WriteLine("\nAnimation Frame:");
                    Console.WriteLine("    " + frames[i]);
                    
                    Thread.Sleep(200); // 200ms delay between frames
                }
            }
            
            Console.Clear();
            Console.WriteLine("Hello, Welcome to Black X Tech!");
            Console.WriteLine("\nAnimation complete!");
        }   
    }
}

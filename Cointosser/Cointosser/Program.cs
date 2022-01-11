using System;

namespace Cointosser
{
    class Program
    {
        static readonly string title = @"
            ______    ______   ______  __    __  ________   ______    ______    ______   ________  _______  
           /      \  /      \ |      \|  \  |  \|        \ /      \  /      \  /      \ |        \|       \ 
          |  $$$$$$\|  $$$$$$\ \$$$$$$| $$\ | $$ \$$$$$$$$|  $$$$$$\|  $$$$$$\|  $$$$$$\| $$$$$$$$| $$$$$$$\
          | $$   \$$| $$  | $$  | $$  | $$$\| $$   | $$   | $$  | $$| $$___\$$| $$___\$$| $$__    | $$__| $$
          | $$      | $$  | $$  | $$  | $$$$\ $$   | $$   | $$  | $$ \$$    \  \$$    \ | $$  \   | $$    $$
          | $$   __ | $$  | $$  | $$  | $$\$$ $$   | $$   | $$  | $$ _\$$$$$$\ _\$$$$$$\| $$$$$   | $$$$$$$\
          | $$__/  \| $$__/ $$ _| $$_ | $$ \$$$$   | $$   | $$__/ $$|  \__| $$|  \__| $$| $$_____ | $$  | $$
           \$$    $$ \$$    $$|   $$ \| $$  \$$$   | $$    \$$    $$ \$$    $$ \$$    $$| $$     \| $$  | $$
            \$$$$$$   \$$$$$$  \$$$$$$ \$$   \$$    \$$     \$$$$$$   \$$$$$$   \$$$$$$  \$$$$$$$$ \$$   \$$

";

        static Random rnd = new Random();
        static int falsebool = 0;
        static int truebool = 0;
        static int num;
        static void Main(string[] args)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(title);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("           github.com/sketchedgrey");
                Console.WriteLine();
                Console.WriteLine("           How many times would you like to flip the coin?");
                string loop = Console.ReadLine();
                for (int i = 0; i < int.Parse(loop); i++)
                {
                    num = rnd.Next(2);
                    Console.Write("Value: " + num + " Loop: " + i + " ");
                    if (num == 0)
                    {
                        falsebool++;
                    }
                    else
                    {
                        truebool++;
                    }
                    Console.Write("Tails: " + falsebool + " Heads: " + truebool);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to restart . . .");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

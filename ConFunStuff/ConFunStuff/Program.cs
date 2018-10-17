using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConFunStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Pless 1. to change your screen color, Pless 2. to make the computer beep, press 3 to increase screen size, press 4 to clear screen, press 5 Mario Theme song, press 6 to make your own song: ");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Any Key....");


                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Any Key....");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Any Key....");
                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Any Key....");
                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Any Key....");
                Console.ReadKey();

            }
            if (user == 2)
            {
                Random rnd = new Random();
                int i;
                while (true)//Makes screen beep at random
                {
                    Console.WriteLine("a1");
                    i = rnd.Next(1, 600);
                    Console.Beep();
                    Console.WriteLine("a2");
                    System.Threading.Thread.Sleep(i);

                }
            }

            if (user == 3)
            {
                while (true)//Makes screen largen
                {
                    for (int L = 1; L < Console.LargestWindowHeight; L++)
                    {
                        Console.WindowHeight = L;
                        Console.WindowWidth = L;
                        System.Threading.Thread.Sleep(100);
                    }
                    Console.ReadKey();
                }
            }

            if (user == 4)
            {
                Console.WriteLine("Hello");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Cleareed");
                Console.ReadKey();

                Console.ReadKey();
            }

            if (user == 5)
            {

                //for (int i = 37; i <= 32767; i += 200)
                //{
                //    Console.Beep(i, 100);
                //}
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
                Console.ReadKey();

            }

    //        GbelowC = 196,
    //A = 220,
    //Asharp = 233,
    //B = 247,
    //C = 262,
    //Csharp = 277,
    //D = 294,
    //Dsharp = 311,
    //E = 330,
    //F = 349,
    //Fsharp = 370,
    //G = 392,
    //Gsharp = 415, 

            if (user == 6)
            {


                ConsoleKeyInfo cki = new ConsoleKeyInfo();
                
                Console.WriteLine("Try your top Keys");
                do
                {
                   

                    while (Console.KeyAvailable == false)
                        Thread.Sleep(0); // Loop until input is entered.
                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.Q)
                    {
                        Console.Beep(196, 500);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.W)
                    {
                        Console.Beep(220, 500);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.E)
                    {
                        Console.Beep(233, 500);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.R)
                    {
                        Console.Beep(247, 500);
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;


                    }
                    if (cki.Key == ConsoleKey.T)
                    {
                        Console.Beep(262, 500);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.Beep(277, 500);

                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                   
                    if(cki.Key == ConsoleKey.U)
                    {
                        Console.Beep(294, 800);

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.J)
                    {
                        Console.Beep(294, 400);

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.I)
                    {
                        Console.Beep(311, 500);

                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.O)
                    {
                        Console.Beep(330, 500);

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.P)
                    {

                        Console.Beep(349, 500);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    if (cki.Key == ConsoleKey.A)
                    {
                        Console.Beep(370, 500);

                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.S)
                    {
                        Console.Beep(392, 500);

                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.D)
                    {
                        Console.Beep(415, 500);

                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (cki.Key == ConsoleKey.F)
                    {
                        Console.Beep(370, 500);

                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }



                } while (cki.Key != ConsoleKey.X);






            }
        }
    }
}

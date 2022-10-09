using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticalWork_III
{
    internal class Program
    {
        /*static void Buttons()
        {
            ConsoleKey[] Buttons = new ConsoleKey[]
            { ConsoleKey.A, ConsoleKey.W, ConsoleKey.S, ConsoleKey.E, ConsoleKey.D, ConsoleKey.F, ConsoleKey.T, ConsoleKey.G,
                ConsoleKey.Y, ConsoleKey.H, ConsoleKey.U, ConsoleKey.J, ConsoleKey.K, ConsoleKey.L, ConsoleKey.O, ConsoleKey.P };
        }*/

        static void Octavi(ConsoleKeyInfo F)
        {
            int[] FivthOctava = new int[]
                { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            int[] SixthOctava = new int[12];
            for (int i = 0; i < SixthOctava.Length; i++) SixthOctava[i] = FivthOctava[i] * 2;

            while (true)
            {
                switch (F.Key)
                {
                    case ConsoleKey.F5:
                        Console.WriteLine("Пятая октава");
                        Sound5(F, FivthOctava);
                        break;
                    case ConsoleKey.F6:
                        Console.WriteLine("Шестая октава");
                        Sound6(F, SixthOctava);
                        break;
                }
                if (F.Key == ConsoleKey.Escape) Environment.Exit(0);
            }
        }

        static void Sound5(ConsoleKeyInfo F, int[] FivthOctava)
         {
             while (true)
             {
                ConsoleKeyInfo note = Console.ReadKey(true);
                Console.Clear();
                switch (note.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(FivthOctava[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(FivthOctava[1], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(FivthOctava[2], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(FivthOctava[3], 200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(FivthOctava[4], 200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(FivthOctava[5], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(FivthOctava[6], 200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(FivthOctava[7], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(FivthOctava[8], 200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(FivthOctava[9], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(FivthOctava[10], 200);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(FivthOctava[11], 200);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(FivthOctava[0], 200);
                        break;
                    case ConsoleKey.L:
                        Console.Beep(FivthOctava[2], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(FivthOctava[1], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(FivthOctava[3], 200);
                        break;
                }
                if (note.Key == ConsoleKey.F6 || note.Key == ConsoleKey.Escape) Octavi(note);
             }
         }

        static void Sound6(ConsoleKeyInfo F, int[] SixthOctava)
        {
            while (true)
            {
                ConsoleKeyInfo note = Console.ReadKey(true);
                Console.Clear();
                switch (note.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(SixthOctava[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(SixthOctava[1], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(SixthOctava[2], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(SixthOctava[3], 200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(SixthOctava[4], 200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(SixthOctava[5], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(SixthOctava[6], 200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(SixthOctava[7], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(SixthOctava[8], 200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(SixthOctava[9], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(SixthOctava[10], 200);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(SixthOctava[11], 200);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(SixthOctava[0], 200);
                        break;
                    case ConsoleKey.L:
                        Console.Beep(SixthOctava[2], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(SixthOctava[1], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(SixthOctava[3], 200);
                        break;
                }
                if (note.Key == ConsoleKey.F5 || note.Key == ConsoleKey.Escape) Octavi(note);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву(F5-F6)");
            ConsoleKeyInfo F = Console.ReadKey(true);
            Octavi(F);
        }
    }
}

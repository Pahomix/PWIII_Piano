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
        static void Octavi(ConsoleKeyInfo F)
        {
            int[] SecondOctava = new int[]
                { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124 };
            int[] ThirdOctava = new int[12];
            for (int i = 0; i < ThirdOctava.Length; i++) ThirdOctava[i] = SecondOctava[i] * 2;
            int[] FourthOctava = new int[12];
            for (int i = 0; i < FourthOctava.Length; i++) FourthOctava[i] = ThirdOctava[i] * 2;
            int[] FivthOctava = new int[12];
            for (int i = 0; i < FivthOctava.Length; i++) FivthOctava[i] = FourthOctava[i] * 2;
            int[] SixthOctava = new int[12];
            for (int i = 0; i < SixthOctava.Length; i++) SixthOctava[i] = FivthOctava[i] * 2;
            int[] SeventhOctava = new int[12];
            for (int i = 0; i < SixthOctava.Length; i++) SeventhOctava[i] = SixthOctava[i] * 2;
            int[] EighthOctava = new int[12];
            for (int i = 0; i < EighthOctava.Length; i++) EighthOctava[i] = SeventhOctava[i] * 2;

            while (true)
            {
                switch (F.Key)
                {
                    case ConsoleKey.F2:
                        Console.WriteLine("Вторая октава");
                        Sound(F, SecondOctava);
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("Третья октава");
                        Sound(F, ThirdOctava);
                        break;
                    case ConsoleKey.F4:
                        Console.WriteLine("Четвертая октава");
                        Sound(F, FourthOctava);
                        break;
                    case ConsoleKey.F5:
                        Console.WriteLine("Пятая октава");
                        Sound(F, FivthOctava);
                        break;
                    case ConsoleKey.F6:
                        Console.WriteLine("Шестая октава");
                        Sound(F, SixthOctava);
                        break;
                    case ConsoleKey.F7:
                        Console.WriteLine("Седьмая октава");
                        Sound(F, SeventhOctava);
                        break;
                    case ConsoleKey.F8:
                        Console.WriteLine("Восьмая октава");
                        Sound(F, EighthOctava);
                        break;
                }
                if (F.Key == ConsoleKey.Escape) Environment.Exit(0);
            }
        }

        static void Sound(ConsoleKeyInfo F, int[] Octava)
        {
            while (true)
            {
                ConsoleKeyInfo note = Console.ReadKey(true);
                Console.Clear();
                switch (note.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(Octava[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(Octava[1], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(Octava[2], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(Octava[3], 200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(Octava[4], 200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(Octava[5], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(Octava[6], 200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(Octava[7], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(Octava[8], 200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(Octava[9], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(Octava[10], 200);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(Octava[11], 200);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(Octava[0], 200);
                        break;
                    case ConsoleKey.L:
                        Console.Beep(Octava[2], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(Octava[1], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(Octava[3], 200);
                        break;
                }
                if (note.Key == ConsoleKey.F2 || note.Key == ConsoleKey.F3 || note.Key == ConsoleKey.Escape ||
                note.Key == ConsoleKey.F4 || note.Key == ConsoleKey.F5 || note.Key == ConsoleKey.F6 ||
                note.Key == ConsoleKey.F7 || note.Key == ConsoleKey.F8) Octavi(note);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву(F2-F8)");
            ConsoleKeyInfo F = Console.ReadKey(true);
            Octavi(F);
        }
    }
}
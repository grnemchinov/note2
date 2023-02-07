using System.Data;
using Ежедневник;

namespace Ежедневник
{
    internal class Program
    {
        static ConsoleKeyInfo key;
        static int position;
        static DateTime datas2 = new DateTime();
        static void Main(string[] args)
        {

            bool k = true;
            datas2 = DateTime.Now;
            while (k != false)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    k = false;
                }
                else
                {
                    data();
                }
            }
        }

        static void peremech()
        {



            if (key.Key == ConsoleKey.UpArrow && position != 2)
            {
                position--;
            }
            if (key.Key == ConsoleKey.DownArrow && position != 4)
            {
                position++;
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                datas2 = datas2.AddDays(1);
            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                datas2 = datas2.AddDays(-1);
            }
        }
        static void menu()
        {
            peremech();
            Console.Clear();
            Console.WriteLine(datas2);
            Console.WriteLine("--------------------");
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

        }





        static void data()
        {
            position = 2;
            while (key.Key != ConsoleKey.Enter)
            {

                key = Console.ReadKey();
                menu();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("1. Сделать c#");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("2. Сделать с#");
            }
            if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("Сходить на пары");
                Console.WriteLine("-------------------");
                Console.WriteLine("чтобы учить с#");
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

            }
            if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("Дома");
                Console.WriteLine("-------------------");
                Console.WriteLine("А также учить с# дома");
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

            }
            key = Console.ReadKey();


        }
    }
}
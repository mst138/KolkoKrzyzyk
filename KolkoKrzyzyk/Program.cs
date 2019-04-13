using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoKrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            string ImieGraczaA = "";
            string ImieGraczaB = "";
            char znakGraczaA = 'x';
            char znakGraczaB = 'o';
            char[,] plansza = new char[3, 3]
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'6', '7', '8' }
            };

            Console.Write("Wpisz imie gracza A:");
            ImieGraczaA = Console.ReadLine();
            Console.Write("Wpisz imie gracza B:");
            ImieGraczaB = Console.ReadLine();

        }
    }
}

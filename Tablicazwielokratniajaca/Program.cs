using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablicazwielokratniajaca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 7; //Tu wstawiasz mnożnik
            int lenght = 5; // Il elementów w tablicy ma być
            int[] result = new int[lenght];
            int licznik = 0; //odlicza tablice od początku

            for (int i = 1; i <= result.Length; i++, licznik++) // zwieksza wyniki od 1 by nie mnożyc przez 0
            {
                result[licznik] = num * i;   //wstawia na pozycje  wunik mnożenia o wartości wiekszej o 1 od nr pozycji w tablicy
            }

            foreach (var item  in result)
            {
                Console.Write($"{item} ");
            }
         Console.ReadLine();

        }
    }
}

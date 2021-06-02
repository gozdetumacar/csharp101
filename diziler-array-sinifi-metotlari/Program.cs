using System;

namespace diziler_array_sinifi_metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            System.Console.WriteLine("***Sırasız Dizi***");
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
            System.Console.WriteLine("***Sıralı Dizi***");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
            
            //Clear

            System.Console.WriteLine("***Array Clear***");

            Array.Clear(sayiDizisi,2,2);
            // sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı 0 yapar.
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //Reverse
            System.Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //IndexOf
            System.Console.WriteLine("***Array IndexOf***");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            System.Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
        }
    }
}

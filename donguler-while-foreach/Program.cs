using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak consoledan girilen sayıya kadar() sayı dahil
            //ort hesaplayıp consolea yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());;
            int sayac = 1;
            int toplam = 0;
            while (sayac <=sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // a-z tüm harfleri yazdır
            char character = 'a';
            while(character < 'z')
            {
                Console.WriteLine(character);
                character ++;
            }

            Console.WriteLine("*** Foreach ***");
            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }
        }
    }
}


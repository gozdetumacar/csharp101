using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";


            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                System.Console.WriteLine("Başarılı!");
                System.Console.WriteLine(outSayi);
            }
            else
            {
                System.Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,3, out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Gözde ", "Tümacar");

            //Metot imzası
            //metotAdı + parametre sayisi + parametre

        }
    }

    class Metotlar 
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            System.Console.WriteLine(veri1 + veri2);
        }
    }
}

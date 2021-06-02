using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            // bu blokta yapılmak istenen işlemler var.
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: "+sayi);
            }
            catch(Exception ex)
            // bu blokta hata yakalanma durumunda ekrana
            // ne yazacağı belirlenir.
            {
                Console.WriteLine("Hata " + ex.Message.ToString());
            }
            finally//optional
            // hata alsa da almasa da en son ekrana 
            // yazılacak şey girilir.
            {
                Console.Write("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Write("İşlem başarıyla tamamlandı.");
            }
        }
    }
}

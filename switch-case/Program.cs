using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

                //Expression(kontrol edilmek istenen koşul)
                switch (month)
                {
                    case 1:
                        System.Console.WriteLine("Ocak ayındasınız");
                        break;
                    case 2:
                        System.Console.WriteLine("Şubat ayındasınız");
                        break;
                    case 3:
                        System.Console.WriteLine("Mart ayındasınız");
                        break;
                    case 5:
                        System.Console.WriteLine("Mayıs ayındasınız");
                        break;
                    default:
                        System.Console.WriteLine("Yanlış veri girdiniz!");
                    break;
                }

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        System.Console.WriteLine("Kış ayındasınız");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        System.Console.WriteLine("İlkbahar ayındasınız");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        System.Console.WriteLine("Yaz ayındasınız");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        System.Console.WriteLine("Sonbahar ayındasınız");
                        break;
                    default:
                    break;
                }
        }
    }
}

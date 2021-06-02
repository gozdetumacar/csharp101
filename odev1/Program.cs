using System;
using System.Collections.Generic;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("*** SORU 1 ***");
            System.Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> evenNumbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine("{0}. sayıyı giriniz: ",i);
                int num = Convert.ToInt32(Console.ReadLine());

                if(num%2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            
            Console.WriteLine("Çift Sayılar");
            foreach(int element in evenNumbers)
            {
                
                Console.WriteLine(element);
            }
            System.Console.WriteLine("**********************************");

            System.Console.WriteLine("*** SORU 2 ***");
            System.Console.WriteLine("Lütfen pozitif birinci sayıyı giriniz: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Lütfen pozitif ikinci sayıyı giriniz: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            List<int> m_n = new List<int>();

            for (int i = 1; i <= n1; i++)
            {
                System.Console.WriteLine("{0}. n sayısını giriniz: ",i);
                int nvalue = Convert.ToInt32(Console.ReadLine());

                if(nvalue == m1 || m1%nvalue==0){
                    m_n.Add(nvalue);
                }
            }
            Console.WriteLine("m'e eşit ya da tam bölünen değerler");
            foreach(int elem in m_n)
            {
                
                Console.WriteLine(elem);
            }

            System.Console.WriteLine("**********************************");

            System.Console.WriteLine("*** SORU 3 ***");
            System.Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            List<string> wordArray = new List<string>();

            for (int i = 1; i <= num1; i++)
            {
                System.Console.WriteLine("{0}. kelimeyi giriniz: ",i);
                string word = Console.ReadLine();
                wordArray.Add(word);

            }
            wordArray.Reverse();
            Console.WriteLine("Kelimelerin Ters Listesi");
            foreach(string w in wordArray)
            {
                Console.WriteLine(w);
            }

            System.Console.WriteLine("**********************************");

            System.Console.WriteLine("*** SORU 4 ***");
            System.Console.WriteLine("Lütfen bir cümle giriniz: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Cümlede yer alan kelime sayısı: "+ sentence.Split(" ").Length);

            int c = 0;
            foreach (string word in sentence.Split(" "))
                c+= word.Length;
            Console.WriteLine("Cümlede yer alan karakter sayısı: " + c.ToString());

        }
    }
}

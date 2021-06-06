using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collections.generic
            Dictionary<int,string> kullanıcılar =new Dictionary<int, string>();
            
            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(18,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Coşar");

            //Dizinin elemanlarına erişim
            System.Console.WriteLine("***Elemanlara Erişim***");
            System.Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }

            //Count;
            System.Console.WriteLine("***Count***");
            System.Console.WriteLine(kullanıcılar.Count);

            //Contains
            System.Console.WriteLine("***Contains***");
            System.Console.WriteLine(kullanıcılar.ContainsKey(12));
            System.Console.WriteLine(kullanıcılar.ContainsValue("Gözde Tümacar"));

            //Remove
            System.Console.WriteLine("***Remove***");
            kullanıcılar.Remove(12);

            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }

            //Keys
            System.Console.WriteLine("***Keys***");
            foreach (var item in kullanıcılar.Keys)
            {
                System.Console.WriteLine(item);
            }
            //Values
            System.Console.WriteLine("***Values***");
            foreach (var item in kullanıcılar.Values)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

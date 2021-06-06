using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //içerisindeki verilere erişim
            //System.Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //    System.Console.WriteLine(item);
            //}

            //AddRange
            System.Console.WriteLine("*** AddRange ***");
            //string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Sort
            System.Console.WriteLine("***Sort***");
            liste.Sort();

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Binary Search
            System.Console.WriteLine("*** Binary Search ***");
            System.Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            System.Console.WriteLine("*** Reverse ***");
            liste.Reverse();

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Clear
            liste.Clear();
            System.Console.WriteLine("*** Clear ***");
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

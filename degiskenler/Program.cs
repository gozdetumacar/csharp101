﻿using System;

namespace değiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int deger = 2;
            //string degisken = " ";
            //if(degisken == " ")

            byte b = 5; //0-255     --- 1 byte
            sbyte c = 5; //-128-127   --- 1 byte
            Console.WriteLine("");

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2 ; //2 byte
            int i = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte

            uint ui = 2; // 4byte 
            long l = 4; // 8 byte
            ulong ul = 4; //8 byte

            //reel sayılar
            float f = 5; //4 byte
            double d = 5; //8 byte
            decimal de = 5; //16 byte

            char ch = '2';  //2byte
            string str = "gözde"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;  //program çalıştırıldığı andaki tarihi ve saati verir.
            Console.WriteLine(dt);

            //object bütün türleri tutabilir.
            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "Gözde Tümacar";
            string ad = "Gözde";
            string soyad = "Tümacar";
            string tamIsim = ad + " " + soyad;

            //Integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool booll = 10>2;

            //Degisken donusumleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString(); //int 20 değerini string'e dönüştürdük

            Console.WriteLine(yeniDeger); // 2020

            int int21 = int20 + Convert.ToInt32(str20); // str20 değerini int'e dönüştürüp toplama işlemi yaptık.
            Console.WriteLine(int21); // 40

            int int22 = int20 + int.Parse(str20); //40
            
            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}
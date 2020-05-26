using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler(); //Rename Ctrl R + M


            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Büşra");
            SelamVer(isim: "Hira");
            SelamVer(isim: "Bircan");
            SelamVer();

            int sonuc = Topla();


            //Diziler / Arrays
            
            string ogrenci1 = "Büşra";
            string ogrenci2 = "Hira";
            string ogrenci3 = "Bircan";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            //stack             /   Heap
            //Garbage Collector çöp tutucu 
            //Array, Class, interface, abstract  == Reference  tip

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Büşra";
            ogrenciler[1] = "Hira";
            ogrenciler[2] = "Bircan";
            //ogrenciler[2] = "Nevin" array 3  elemanlı olmalı yoksa çalışmaz
            ogrenciler = new string[4];
            ogrenciler[2] = "Nevin";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "istanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            //Referenslarda referans numaraların agöre bakıyoruz.
            sehirler2 = sehirler1; //şehirler 1 şehirler ikinin referans numarasına eşit demektir.
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            //int, double, bool değer tipleridir
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //sayi2 = ?? 10 olur.

            Person person1 = new Person();
            person1.FirstName = "Büşra";

            Person person2 = new Person();
            person2.FirstName = "HiraNur";

            foreach (string sehir  in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "istanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }





            Console.ReadLine();
        }
        //Void methodlar değer dönddürmez sadece işi yapar.
        //parantez içindekiler parametre oluyor
        //Resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }
        //deger ver dediği  zama return döndür
        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "Selam";                                // string: Metinsel Değişken
            Console.WriteLine(mesaj);                             // Console.WriteLine("Merhaba"); //  Yazı yazmaya yarar

            double tutar = 100000;          //Sayısal dğişkenler ondalık olarak kullanılır.(db den gelir)
            Console.WriteLine(tutar * 1.18);

            int sayi = 200;   // tam sayi içerir
            Console.WriteLine(sayi);

            bool girisYapmisMi = false; //true false döndürür
            Console.WriteLine(girisYapmisMi);

            //Neseneye yönelik programlama  bir kutu içinde bir düzen içinde bulunmasıdır.Kutu gibi


            string ad = "Büşra";
            string soyad = "Özmen";
            int dogumYili = 1994;
            long tcNo = 12345678910;
        }
    } //Blok

    //Public yaptığımızda başka yerlerdende erişile bilir.
    //pascal casing

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}

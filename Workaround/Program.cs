using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();
            vatandas1.Ad = "Tuğçe";
            vatandas1.Soyad = "Yavaşoğlu";
            vatandas1.DogumYili = 2000;
            vatandas1.TcNo = 12345678910;

            SelamVer(isim: "Engin");
            SelamVer(isim: "Aysu");
            SelamVer(isim: "Tuğçe");
            SelamVer();

            int sonuc = Topla(6,58);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Tuğçe";
            ogrenciler[1] = "Aysu";
            ogrenciler[2] = "Sevgi";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            List<string> yeniSehirler = new List<string>() { "Ankara", "İstanbul", "İzmir"};
            yeniSehirler.Add("Gaziantep");

            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }




            Person person1 = new Person();
            person1.FirstName = "Tuğçe";
            person1.LastName = "Yavaşoğlu";
            person1.NationalIdenty = 123;
            person1.DateOfBirthYear = 2000;

            Person person2= new Person();
            person2.FirstName = "Aysu";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);





            Console.ReadLine();
        }
        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1 =5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

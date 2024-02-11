using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mesaj = "Selam";
            //double tutar = 10000;
            //int sayi = 100;
            //bool girisYapmısMi = false;

            //string ad = "Engin";
            //string soyad = "Demiroğ";
            //int dogumYili = 1985;
            //long tcNO = 12345678910;


            //Console.WriteLine(tutar * 1.18);

            //Console.WriteLine(tutar * 1.18);

            Vatandas vatandas = new Vatandas();
            


            Console.ReadLine();
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

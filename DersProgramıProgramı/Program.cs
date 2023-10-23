using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramıProgramı
{

//Kullanıcı dersin adının sonrasında da haftalık toplam saatini yazacak.Bu toplam saat kadar hafta içi günlerine dersler dağılacak.
//Dersler hafta içi 09:00 da başlar, 15:00 da biter.
//Her ders saati 50 dk'dır.Ara ise dersi takip eden 10dk'dır.
//Haftada toplamda 25 saatten fazla girişler reddedilecek. 
//Her gün saat 12:00 ile 13:00 arasında ders olmaz. (Öğle arası)
//Derslerin yerleri rastgele olacak ve dersler ya da aralar çakışmayacak.
//Örnek giriş : Matematik,15,Türkçe,10
    /* 
     * Pazartesi           
     * 09.00 - 09.50 mat
     * 09.50-10.00 ara
     * 10.00 - 10.50 türkçe
     * 10.50-11.00 ara
     * 11.00 - 11.50 mat
     * 11.50 -12.00 ara
     * 12.00 - 13.00 öğle arası
     * 13.00 - 13.50 mat
     * 13.50-14.00 ara
     * 14.00 - 14.50 mat
     * 14.50 - 15.00 ara */
    public class Program

    {
        static void Main(string[] args)

        {

            Console.WriteLine("Lütfen ders isimlerini ve saatlerini arada virgul olacak sekilde giriniz");

   

            string okunan = Console.ReadLine();

            string[] parcalanan = okunan.Split(',');

            // okunanı split metodu kullanarak parcaladık

            Ders[] dersler = new Ders[parcalanan.Length / 2];

            int j;

            j = 0;

            while (j < parcalanan.Length)

            {

                for (int i = 0; i < dersler.Length; i++)

                {

                    dersler[i] = new Ders();
                    dersler[i].Ad = okunan.Split(',')[j];
                    dersler[i].Saat = int.Parse(okunan.Split(',')[j + 1]);

                    j += 2;

                    // 0 2 4 6 8

                    // pars metodu ile istediğim int değerine cevirdim

                }
            }

            Ders[] dersZamanlari = new Ders[25];

            Random rnd = new Random();

            for (int i = 0; i < dersler.Length; i++)

            {

                 for(int k = 0; k < dersler[i].Saat; k++)

                {
                    int rastgeleZaman = rnd.Next(0, 25);

                    if (dersZamanlari[rastgeleZaman] == null)

                    {
                        dersZamanlari[rastgeleZaman] = dersler[i];

                    }

                    else

                    {

                        k--; 
                        // döngüyü bir daha dönmesi için azaltık 
                        continue;
                    }
               
                }


            }

            Console.WriteLine("****Ders Programı****");
            Console.WriteLine();
            Console.WriteLine("Pazartesi");

            double sayac = 09.00;

            for(int i = 0; i < 5; i++)

            {

                if(sayac ==12)

                {

                    Console.WriteLine(sayac+".00"+"-"+(sayac+1)+".00"+""+"Ögle Arası");

                    sayac = sayac + 1;

                }

                if (dersZamanlari[i]!= null)

                {
                    Console.WriteLine(sayac + ".00" + "-" + sayac + ".50" + "" + dersZamanlari[i].Ad);
                    Console.WriteLine(sayac+".50"+"-"+(sayac+1)+".00"+""+"Ara");

                    sayac = sayac + 1;


                }



            }

            Console.WriteLine();
            Console.WriteLine("Salı");

            sayac = 09.00;


            for (int i = 0; i < 10; i++)

            {

                if (sayac == 12)

                {

                    Console.WriteLine(sayac + ".00" + "-" + (sayac + 1) + ".00" + "" + "Ögle Arası");

                    sayac = sayac + 1;

                }

                if (dersZamanlari[i] != null)

                {
                    Console.WriteLine(sayac + ".00" + "-" + sayac + ".50" + "" + dersZamanlari[i].Ad);
                    Console.WriteLine(sayac + ".50" + "-" + (sayac + 1) + ".00" + "" + "Ara");

                    sayac = sayac + 1;


                }



            }

            Console.WriteLine();
            Console.WriteLine("Çarşamba");

            sayac = 09.00;


            for (int i = 0; i < 15; i++)

            {

                if (sayac == 12)

                {

                    Console.WriteLine(sayac + ".00" + "-" + (sayac + 1) + ".00" + "" + "Ögle Arası");

                    sayac = sayac + 1;

                }

                if (dersZamanlari[i] != null)

                {
                    Console.WriteLine(sayac + ".00" + "-" + sayac + ".50" + "" + dersZamanlari[i].Ad);
                    Console.WriteLine(sayac + ".50" + "-" + (sayac + 1) + ".00" + "" + "Ara");

                    sayac = sayac + 1;


                }



            }

            Console.WriteLine();
            Console.WriteLine("Perşembe");


            sayac = 09.00;


            for (int i = 0; i < 20; i++)

            {

                if (sayac == 12)

                {

                    Console.WriteLine(sayac + ".00" + "-" + (sayac + 1) + ".00" + "" + "Ögle Arası");

                    sayac = sayac + 1;

                }

                if (dersZamanlari[i] != null)

                {
                    Console.WriteLine(sayac + ".00" + "-" + sayac + ".50" + "" + dersZamanlari[i].Ad);
                    Console.WriteLine(sayac + ".50" + "-" + (sayac + 1) + ".00" + "" + "Ara");

                    sayac = sayac + 1;


                }



            }

            Console.WriteLine();
            Console.WriteLine("Cuma");

            sayac = 09.00;


            for (int i = 0; i < 25; i++)

            {

                if (sayac == 12)

                {

                    Console.WriteLine(sayac + ".00" + "-" + (sayac + 1) + ".00" + "" + "Ögle Arası");

                    sayac = sayac + 1;

                }

                if (dersZamanlari[i] != null)

                {
                    Console.WriteLine(sayac + ".00" + "-" + sayac + ".50" + "" + dersZamanlari[i].Ad);
                    Console.WriteLine(sayac + ".50" + "-" + (sayac + 1) + ".00" + "" + "Ara");

                    sayac = sayac + 1;


                }



            }




        }

    }

       
    class Ders

    {

        private int _saat;
        public string Ad { get; set; }

        public int Saat 
        
        { 
            
            get

            {
                return _saat;
            }

            set

            {
                _saat = value;

                if(_saat > 25)

                {
                    Console.WriteLine("Tek ders icin 25 saat ve fazlası girilemez");


                }
            }
        
        }



    }
}

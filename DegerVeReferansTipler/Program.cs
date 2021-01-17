using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,double,float,decimal,bool = değer tip
            //array,class,interface = referans tip

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 10 dur.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;//Dizinin ismi dizinin adresidir.
            sayilar2[0] = 999;
            //sayilar1[0] = 999 olur.
            
        }
    }
}

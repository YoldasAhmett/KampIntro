using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelitirici Kamp kursu";
            string kurs2 = "Yazılıma başlangıç kursu";
            string kurs3 = "Java";

            //array

            string[] kurslar = new string[]
            {
                "Yazılım Gelitirici Kamp kursu",
                "Yazılıma başlangıç kursu",
                "Java",
                "Python",
                "C#"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\nSayfa sonu - footer");
        }
    }
}

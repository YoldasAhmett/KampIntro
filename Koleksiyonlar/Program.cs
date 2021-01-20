using System;
using System.Collections.Generic; //List sınıfının yani koleksiyonların kullanılması
//için bu kütüphanenin kullanılması gerekir.

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler1 = new string[] {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);
            Console.WriteLine(isimler1[2]);
            Console.WriteLine(isimler1[3]);
            isimler1 = new string[5];//Böyle yaparak isimler1 dizisini genişletmiş olmadık.
                                     //dizinin gösterdiği adresi değiştirmiş olduk yani
                                     //önceki değerler artık bu dizide yok.
            isimler1[4] = "Ahmet";
            Console.WriteLine(isimler1[4]);
            Console.WriteLine(isimler1[0]);

            //Yukarıda gördüğümüz gibi diziler dinamik bir yapıda değildir. Bu sebeple biz 
            //dinamik yapıda olduklarından dolayı koleksiyonları kullanırız.

            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ahmet");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}

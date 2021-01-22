using System;
using System.Collections.Generic;

namespace Collections___YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Kasım","Ayşe","Tahir","Sinan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "Erkan";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            // Dizilere yeniden ekleme yapıldığı zaman ya kod patşar ya da ilk değerleri kaybederiz.
            // Arrayler yani diziler yerine collections ları kullanırız

            // Collectionlar bize ilk başa eklediğimiz bir kaç değerin üzerine yeni değerler eklememizi sağlayan bir kütüphanedir.


            List<string> isimler2 = new List<string> { "Kasım", "Ayşe", "Tahir", "Sinan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Erkan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}

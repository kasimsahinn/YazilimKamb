using System;

namespace GenericsIntro___YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aslında Arkaplanda T olarak atadığımız yeni değeri stringe çeviriyoruz
            MyList<string> isimler = new MyList<string> ();

            isimler.Add("Kasım");
            isimler.Add("Kasım");
            isimler.Add("Kasım");
            isimler.Add("Kasım");
            isimler.Add("Kasım");
            isimler.Add("Kasım");
            isimler.Add("Kasım");
            isimler.Add("Kasım");
            isimler.Add("Kasım");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}

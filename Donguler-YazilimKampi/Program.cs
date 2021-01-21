using System;

namespace Donguler_YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Döngüler Birbirine benzeyen işlemleri tekrar etmek için kullanırız

            // For Döngüsü
            // for (Başlangıç Değeri, Şart , İşlem) Yani i değerini 1 den başla, 10 dan küçük olduğu sürece çalış ve her çalıştığında i' ye 1 ekle; 
            Console.WriteLine(" --------For Döngüsü-------- ");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("-------- For Döngüsünü 2-2 arttırır --------");
            for (int i = 1; i < 10; i+=2)               // i+=2 = i+=2
            {
                Console.WriteLine(i);
            }

            // Array - Dizi 
            Console.WriteLine("-------- Array Dizi Kullanımı --------");

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin temel Kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python Kursu";
            string kurs5 = "C# Kursu";

            // Kurslar adında eklediğimiz array bizim tüm kurslarımızı(kurs1,kurs2,kurs3 vb.) tek bir değikende tutmamızı sağlar ve dizi şeklinde bize verir);
            // Yukarıdaki gibi tek tek tutmak yerine hepsini aynı array içinde tuttuk;
            string[] kurslar = new string[] { 
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin temel Kurs",
                "Java Kursu",
                "Python Kursu",
                "C# Kursu"
            };

            // For Daha genel amaçlar için kullanılır Ancak foreachin yaptığı görevi burda da yapar;
            Console.WriteLine("----- For Döngüsü İle -----");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); // Kurslar Array inin "i" ninci elemanını getirir bize;
            }

            // Foreach = Dizi temelli yapıları tek tek dönmeye yarar, Dizilere uygulanır;
            // Foreachi biz diziler arasında kolay dönmek için kullanırız ve for döngüsünün yaptığı aynı işi burda yapar;
            // foreach( Değişken, Alias(Kendi Koyduğumuz değişken ismine denir kısaca takma isim) İN Kursları Dolaş);
            Console.WriteLine("----- Foreach Döngüsü İle -----");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine( kurs);
            }


            



        }
    }
}

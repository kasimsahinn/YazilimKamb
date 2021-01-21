using System;

namespace Class_YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aynı int veya string vb. değişkenler tanımladığımmız gibi kendi yarattığımız bir değişkende,
            // tanımlayabiliriz ancak bunun için bir class oluşturmamız gerekmektedir,
            // Class lar içlerinde yalnızca int veya string şeklinde değil bütün hepsinden tutabilir ( int,string vs.);
            // kurs1'in  içine atadığımız değişkenlere değer verilmesi;


            Kurs kurs1 = new Kurs();  // kurs1 Adlı bir değer tanımlaması;
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Kasım Şahin";
            kurs1.KursIzlenmeOrani = 68;
            
            Kurs kurs2 = new Kurs(); // kurs2 Adlı bir değer tanımlaması;
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ayşe Şahin";
            kurs2.KursIzlenmeOrani = 99;

            Kurs kurs3 = new Kurs(); // kurs3 Adlı bir değer tanımlaması;
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Esma Şahin";
            kurs3.KursIzlenmeOrani = 78;

            Kurs kurs4 = new Kurs(); // kurs4 Adlı bir değer tanımlaması;
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Züleyha Şahin";
            kurs4.KursIzlenmeOrani = 100;



            // Kurs Adının Eğitmenin ve izlenme oranının klasik yöntem ile yazılışı
            Console.WriteLine(
                "Bu kursun Adı : " + kurs1.KursAdi + " " +
                "Kursun Eğitmeni : " + kurs1.Egitmen + " " +
                "İzlenme Oranı : " + kurs1.KursIzlenmeOrani+ "%"
                );
            Console.WriteLine(
                "Bu kursun Adı : " + kurs2.KursAdi + " " +
                "Kursun Eğitmeni : " + kurs2.Egitmen + " " +
                "İzlenme Oranı : " + kurs2.KursIzlenmeOrani + "%"
                );
            Console.WriteLine(
                "Bu kursun Adı : " + kurs3.KursAdi + " " +
                "Kursun Eğitmeni : " + kurs3.Egitmen + " " +
                "İzlenme Oranı : " + kurs3.KursIzlenmeOrani + "%"
                );
            Console.WriteLine("----------------------"); 

            // Önerilen ve kullanılması gereken Yöntem bu
            // Yukarıda 15 Satırda yaptığımız işlemi aşağıdaki array sistemi ile yalnızca 5 satırda çözebiliyoruz
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(
                "Bu kursun Adı : " + kurs.KursAdi + " " +
                "Kursun Eğitmeni : " + kurs.Egitmen + " " +
                "İzlenme Oranı : " + kurs.KursIzlenmeOrani + "%");
            }
        }
    }

    class Kurs
    {
        // Public ile bir değişken içine değer atıyoruz;
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int KursIzlenmeOrani { get; set; }
    }

}

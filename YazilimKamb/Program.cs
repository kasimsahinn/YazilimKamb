using System;

namespace YazilimKamb
{
    class Program
    {
        static void Main(string[] args)
        {

            // Type Safety - Tip Güvenliği örneğin string bir ifade tanımlarsak ifdenin başına string olduğunu yazmalıyız;

            // Değişkenleri kullanmamızın en büyük nedenlerinden biri; bir kısmı değiştiriceğimiz zaman yanlızca değişkeni değiştirerek 10 sayfayıda aynı anda değiştirebiliriz;

            // Değişkenin yanına yazdığımız isim (Aşağıdaki kategoriEtiketi) aslında bir değer tutucudur. diğer bir isimle "Alias" olarak adlandırılır;
            
            string düzYazi = " Kategori ";

            int tamSayi = 32000;

            double ondalikliSayi = 10.50;

            bool trueFalse = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.55;


            Console.WriteLine("-------- String İfade Örneği --------");
            Console.WriteLine(düzYazi);
            
            Console.WriteLine("-------- İntereger İfade Örneği --------");
            Console.WriteLine(tamSayi);
            
            Console.WriteLine("-------- Double İfade Örneği --------");
            Console.WriteLine(ondalikliSayi);

            Console.WriteLine("-------- İf/Else Örneği --------");
            if (trueFalse == false)
            {
                Console.WriteLine("Sisteme Giriş Yapmadınız");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yaptınız");
            }

            Console.WriteLine("-------- İf/Elseİf/Else Örneği --------");
            if(dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar Yükseldi");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Dolar Düştü");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi");
            }
        }
    }
}

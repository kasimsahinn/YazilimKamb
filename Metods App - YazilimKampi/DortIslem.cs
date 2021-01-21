using System;
using System.Collections.Generic;
using System.Text;

namespace Metods_App___YazilimKampi
{
    class DortIslem
    {   // Bu uygulamada Metotları kullanarak Bir hesap makinesi uygulaması yaptık özet ile public void ile bir işlem belirledik
        // işlemin ne yapacağını alt tarafında tanımladık ve ekranda yazdırdık. ardından program cs bölümüne gidip ==>
        public void Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplama İşlemi = " + sayi1 + "+" + sayi2 + "="  + toplam);
        }
        public void Cikarma(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine("Çıkartma İşlemi = " + sayi1 + "-" + sayi2 + "=" + cikarma);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Çarpma İşlemi = " + sayi1 + "x" + sayi2 + "=" + carpma);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine("Bölme İşlemi = " + sayi1 + "/" + sayi2 + "=" + bolme);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_YazilimKamp
{
    class SepetManager
    {
        
        // Bir classın sonunda manager, services, data-acces, controller, gibi ifadeler var ise bir operasyon tutuyor demektir;


        // Naming convention - İsimlendirme 

        // Ekle classını ekledik ancak neyi eklemek istediğimizi vermedik
        // Eklemek istediğimiz şeye parametre denir

        // 1. Yol ==>(Önerilen Bu)
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler " + urun.urunAdi + " Sepete Eklendi");
        }

        // 2. Yol ==> ( Hatalı bir kullanımdır aslında)
        public void Ekle2(string Adi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler " + Adi + " Sepete Eklendi");
        }



    }
}

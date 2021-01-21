using System;

namespace Methods_YazilimKamp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Metotlar Bize Tekrar tekrar kullanabilirliği sağlayan bir ortamı sağlıyor yani kendimizi tekrar etmememiz için kullandığımız en önemli yöntem;

            /*
            string urunAdi = "Elma";
            double fiyati = 15;                             Classlar Teker Teker nitelik verdiğimiz değerlerin her birini teker teker değişkenlerde tutmak
            string aciklama = "Amasya Elması";              yerine hepsini aynı değişken içersinde bir class olarak tutar
            */




            Urun urun1 = new Urun(); // urun1 değerini bir class olarak belirleriz
            urun1.urunAdi = "Elma"; // daha önceden belirlediğimiz ana classlar ile urun1 i birleştiririz
            urun1.urunFiyati = 15;
            urun1.Id = 123456;
            urun1.urunAciklama = "Amasya Elması";
            urun1.urunReyonu = 2;
            urun1.urunStok = 5;

            Urun urun2 = new Urun();
            urun2.urunAdi = "Karpuz";
            urun2.urunFiyati = 12;
            urun2.Id = 12345;
            urun2.urunAciklama = "Diyarbakır Karpuzu";
            urun2.urunReyonu = 1;
            urun2.urunStok = 599;

            Urun urun3 = new Urun();
            urun3.urunAdi = "Portakal";
            urun3.urunFiyati = 8;
            urun3.Id = 1234;
            urun3.urunAciklama = "Sıkmalık Portakal";
            urun3.urunReyonu = 3;
            urun3.urunStok = 421;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};
            // => in urunler dediğimizde ürünler dizimizin her bir elemanınını teker teker gezmesi manasına gelir , 
            // urun yazmamızın sebebi ise alian değerimizdir yani takma isim;
            // En başa yazdığımız Urun ise ne ile çalışacağını belirtmek içindir;
            foreach (Urun urun in urunler) 
            {
                Console.WriteLine(
                        "Ürünün adı : " + urun.urunAdi + " " +
                        "Ürünün Fiyatı : " + urun.urunFiyati + " " + "TL" + " "+
                        urun.urunAciklama + " " +
                        "Ürün" + " " +urun.urunReyonu + "." + "Reyonda" + " " + "Bu üründen " + urun.urunStok + " " + "Adet var "
                    );
                
            }

            Console.WriteLine("-------- SepetManager --------");

            // İnstance Class örneği oluşturmaya veren isim
            // Bir classı alıp kendi koyduğumuz bir isim ile tanımlamaya denir
            SepetManager sepetManager = new SepetManager();

            // Ekle Classına SepetManager dosyasında Console.WriteLine("Sepete Eklendi!"); Değerini atadığımız için Aşağıda çağırdığımızda
            // Ekrana Console.WriteLine("Sepete Eklendi!"); Yazdırdı;
            // Bu yöntemin ismi encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            Console.WriteLine("-------- 2. Yol İle Sepete Ekle --------");

            // 2. yolda örneğin yeni bir imza özellik eklemek istersek
            // hem tüm sayfaları değiştirmek zorundayız hemde classa özellik vermek zorundayız

            sepetManager.Ekle2("Kavun", "Sarı Sarı", 15, 9);
            sepetManager.Ekle2("Kiraz", "Kırmızı", 15, 9);
            sepetManager.Ekle2("Vişne", "Kırmızı", 15, 4);

        }
    }
}

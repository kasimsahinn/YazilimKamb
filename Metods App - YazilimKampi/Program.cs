using System;

namespace Metods_App___YazilimKampi
{
    class Program
    {   // <== DortIslem classımızı bir isme yani alianca bağladık (dortIslem) Ardından DortIslem Class sayfamızda tanımladığımız 
        // 2 sayının (int sayi1, int sayi2) değerlerini belirttik. böylece yapacak olduğumuz işlemi yaptık; 
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            
            dortIslem.Toplama(5, 6);

            dortIslem.Cikarma(10, 5);

            dortIslem.Carpma(10, 5);

            dortIslem.Bolme(100, 50);

            
            

            
        }
    }
}

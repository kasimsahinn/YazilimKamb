using System;

namespace OOP1__YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Birimlere Değer Atamanın Birinci Oluşturma Yolu
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            // Birimlere Değer Atamanın İkinci Oluşturma Yolu
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();         // Açılımı aslında ProductManager Türünde Bir productManager değişkeni oluşturmaya gelir,
            productManager.Add(product1);                                 // Yani aslında "string isim = 'Kasım';" kod dizimnden bir farkı yoktur;
            Console.WriteLine(product1.ProductName);                      // ProductManager productManager = new ProductManager(); ifadesinde eşittirin sol tarafı
                                                                          // Stack Türüne Sağ tarafı ise Heap Türüne eşittir Sol atarfı yazarak Stackte oluştururuz
                                                                          // new parametresini açarakta heap tarafında oluştururuz.




            


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1__YazilimKampi
{
    class ProductManager
    {
        
        //Manager tarzı isimlendirmeler genelde ürünle ilgili operasyonlarda kullanılır,
        // Ekleme Silme Düzeltme Gibi operasyonların tümüne CRUD Denir!;
        


        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi. ");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi. ");
        }
        public void Remove(Product product)
        {
            Console.WriteLine(product.ProductName + " Silindi. ");
        }

        




    }
}

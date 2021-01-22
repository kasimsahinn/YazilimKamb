using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1__YazilimKampi
{
    class Product
    {

        // Product Tipi classlarda yalnızca özellik bulunur

        public int Id { get; set; } // Id Bir nesneyi diğerinden ayırt etmek için kullanırız örneğin İnsanların tc no ile ayrılması gibi
        public int CategoryId { get; set; } // Foreign Key olarak adlandırırız foreign keyleri Id den sonra yazarız(yazmasakta sıkıntı olmaz ancak kodun okunurluğu açısından kolaylık sağlar)
        public string ProductName { get; set; } // ProductName Ürün İsmi demektir
        public double UnitPrice { get; set; }   // UnitPrice Ürün fiyatı demek
        public int UnitInStock { get; set; } // UnitInStock Stoktaki ürün manasına gelir


        


    }
}

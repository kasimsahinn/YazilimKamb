using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3___YazilimKampi
{
    // Her sayfada yaptığımız ayrı içerikli aynı işlemleri Tek sayfada topladığımız sayfa base sayfadır ve class yerine interface kullanırız;
    // interfaceleri birbirinin alternatifi olan ancak kod içerikleri farklı olan durumlar için kullanırız

    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
        
    }
}

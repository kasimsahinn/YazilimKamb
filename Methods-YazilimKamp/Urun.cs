using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_YazilimKamp
{
    class Urun
    {

        // Property- özellik
        // Classların bir diğer işlevide özellik tutmak için kullanılmasıdır
        public int    Id           { get; set; }
        public string urunAdi      { get; set; }
        public double urunFiyati   { get; set; }
        public string urunAciklama { get; set; }
        public int    urunReyonu   { get; set; }

        public int urunStok { get; set; }

    }
}

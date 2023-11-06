using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_KitapDukkani
{
    class Kitap
    {
        public string KitapAdi { get; set; }
        public string KitapTuru { get; set; }
        public int SayfaSayisi { get; set; }
        public double Fiyat { get; set; }
        public Yazar KitabinYazari { get; set; }

        public Kitap() { }
    }
}

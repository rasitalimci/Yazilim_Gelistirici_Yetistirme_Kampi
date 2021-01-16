using System;
using System.Collections.Generic;
using System.Text;

namespace methots
{
    class SepetMeneger
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("urun basariyla sepete eklendi" + " " + urun.Name);


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
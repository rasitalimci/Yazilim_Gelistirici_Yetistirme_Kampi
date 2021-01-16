using System;

namespace methots
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Name = "Elma";
            urun1.Price = 35;
            urun1.Aciklma = "Ankara elmasi";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Name = "Karpuz";
            urun2.Price = 55;
            urun2.Aciklma = "Diyarbakir karpuzu";
            urun2.StokAdedi = 5;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Aciklma);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("------------------");

            }

            SepetMeneger sepetManager = new SepetMeneger();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 8);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 10);

        }
    }
}
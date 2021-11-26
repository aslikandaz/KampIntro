using System;

namespace KampOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "ekmek";
            urun1.UrunSayisi = 50;
            urun1.UrunMarkasi = "fırın";

            Product urun2 = new Product();
            urun2.UrunAdi = "çikolata";
            urun2.UrunSayisi = 20;
            urun2.UrunMarkasi = "ülker";

            Product urun3 = new Product();
            urun3.UrunAdi = "yoğurt";
            urun3.UrunSayisi = 25;
            urun3.UrunMarkasi = "dost";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            for (int i = 0; i <urunler.Length ; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].UrunSayisi + " " + urunler[i].UrunMarkasi);
            }

            Console.WriteLine("for bitti");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " " + urun.UrunSayisi + " " + urun.UrunMarkasi);
            }

            Console.WriteLine("foreach bitti");

            int k = 0;
            while (k<urunler.Length)
            {
                Console.WriteLine(urunler[k].UrunAdi + " " + urunler[k].UrunSayisi +" "+ urunler[k].UrunMarkasi);
                k++;
            }
          
          
        }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public int UrunSayisi { get; set; }
        public string UrunMarkasi { get; set; }

    }
}

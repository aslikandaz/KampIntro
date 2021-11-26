using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "elma";
            double fiyati = 15;                 //aslında bu üç satır birlikte bir ürünü ifade eder 
            string aciklama = "amasya elması"; // class lar da bu üçünü birlikte tutmamıza yarayan yapıdır

            string[] meyveler = new string[] { "elma", "karpuz" };

            Urun urun1 = new Urun(); //class tanımlamak (classın örneği)
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            //arraylar aynı veri tipinde birden fazla datayı tutmamızı sağlar
            // buradaki urun arrayi de birden fazla class veri türündeki veriyi depolamamızı sağlamış oldu
           
            Urun[] urunler = new Urun[] { urun1, urun2 };

            
            foreach (Urun urun in urunler) //in ürünler demek ürünler dizisini tek tek gez demek, 2. urun ise o anki dönülen elemana verdiğimiz alias, ilk urun ise veri tipi bunun yerine var da yazsak olur.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("....................");
            }

            Console.WriteLine("---------------Metotlar-------------");

            //instance - örnek oluşturmak
            //encapsulation - ayrı ayrı yazılacak ve düzensiz olacak yapıyı bir kapsül(düzen) içine sokma

            SepetManager sepetManager = new SepetManager(); //fonksiyonu classta tanımladığımız için class gibi önce onun da örneğini oluşturuyoruz
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) // ilk ürün gelecek verinin veri tipi ikinci ürün ise aşağıda kullanırken vereceğim alias
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // bu şekilde yazmamız hatalı çünkü yeni bir özellik eklemek istediğimizde tüm alanları elle tekrar doldurulmak zorunda kalırız
        {                                                                               
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);            
        }
    }
}

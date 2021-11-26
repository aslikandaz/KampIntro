using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 }; //kurs veri tipli  array (dizisi) oluşturdum içinde kurs objesi tutuyorum.

            foreach (var Kurs in kurslar) // var yerine Kurs da yazabilirdik bu veri tipi demek. var olarak kaldığında veri tipini kendi bulur.
            {
                Console.WriteLine(Kurs.KursAdi + " : " + Kurs.Egitmen); // stringleri topluyorum burada

            }



            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}

using System;

namespace Donguler1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"yazılım geliştirici yetiştirme kampı",
            "programlamaya giriş için temel kurs",
            "java","phyton","C#"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }





            Console.WriteLine("sayfa sonu - footer");
        }
    }
}

using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya giriş kampı";
            string kurs3 = "java";

            //array - dizi
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı","programlamaya giriş kampı","java","python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
               Console.WriteLine(kurslar[i]);
               Console.ReadKey();
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //dizileri tek tek dolaşmaya yarıyor
            {
                Console.WriteLine(kurs);
                Console.ReadKey();
            }
            
            Console.WriteLine("sayfa sonu -footer");
        }
    }
}

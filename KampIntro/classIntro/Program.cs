using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "sena";
            int yasi = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "ENGIN DEMIROG";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "MURAT YUCEDAG";
            kurs2.IzlenmeOrani = 85;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PYTHON";
            kurs3.Egitmen = "SADİ EVREN SEKER";
            kurs3.IzlenmeOrani = 94;

            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }



            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }
}

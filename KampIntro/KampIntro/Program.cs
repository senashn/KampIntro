using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            string kategorietiketi = "kategori";
            int ogrencisayisi = 3200;
            double faizorani = 1.45;
            bool sistemegirisyapmismi = true;
            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("azalış butonu");
                
            }
            else if (dolardun < dolarbugun)
            {
                Console.WriteLine("artış butonu");
                
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
                
            }


            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategorietiketi);
        }
    }
}

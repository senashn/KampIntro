using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convension
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tebrikler sepete eklendi : "+ urun.Adi);
            Console.ReadLine();
            
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("tebrikler, sepete eklendi : " + urunAdi);
        }
    }
}

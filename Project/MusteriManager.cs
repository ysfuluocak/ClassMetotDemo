using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        int index = 0;
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi");            
            musteriler.Add(musteri);                     
        }

        public void MusteriSil(Musteri musteri)
        {
            foreach (var item in musteriler)
            {
                if (musteri.Id == item.Id && musteri.Name == item.Name)
                {
                    index = item.Id - 1; 
                }
            }
            musteriler.RemoveAt(index);
            Console.WriteLine("Musteri Silindi!");
        }

        public void MusteriGetir()
        {          
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri adı : " + musteri.Name);
            }
        }

        

    }
}

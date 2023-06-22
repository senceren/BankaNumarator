using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaNumaratörVeri
{
    public class Banka
    {
       
        public List<Musteri> Musteriler { get; set; } = new();

        public int VIPIslemSayisi { get; set; } = 0;
        public int BireyselIslemSayisi { get; set; } = 0;
        public int GiseIslemSayisi { get; set; } = 0;


        public void ToplamYapilanİslemSayisi(Banka banka)
        {
            foreach (Musteri m in banka.Musteriler)
            {

                if (m.Islem == Islem.VIP)
                {
                    VIPIslemSayisi++;
                }
                else if (m.Islem == Islem.Bireysel)
                {
                    BireyselIslemSayisi++;
                }
                else
                    GiseIslemSayisi++;
            }

        }
    }
}

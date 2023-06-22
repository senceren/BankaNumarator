using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaNumaratörVeri
{
    public class IslemYapilanYer
    {
        public Musteri Musteri { get; set; }

        public string İslemYapılıyor(Musteri musteri)
        {
            return $"{musteri.Islem} müşteri işlemi yapılıyor.";
        }
    }
}

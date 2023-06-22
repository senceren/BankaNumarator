using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaNumaratörVeri
{
    public class VIPMusteri : Musteri
    {
        public Islem Islem { get; } = Islem.VIP;
    }
}

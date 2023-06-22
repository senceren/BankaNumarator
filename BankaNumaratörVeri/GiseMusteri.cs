using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaNumaratörVeri
{
    public class GiseMusteri : Musteri
    {
        public Islem Islem { get; } = Islem.Gise;
    }
}

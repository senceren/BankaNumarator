using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaNumaratörVeri
{
    public class BireyselMusteri : Musteri
    {
        public Islem Islem { get; } = Islem.Bireysel;

    }
}

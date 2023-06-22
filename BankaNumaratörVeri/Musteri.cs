using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaNumaratörVeri
{
    public class Musteri
    {
        private string _tcNo;
        public string TCno
        {
            get { return _tcNo; }
            set
            {
                _tcNo = value;
                GizliTCno = value != null ? new string('*', value.Length - 1) + value[value.Length - 1] : value;
            }
        }
        public string GizliTCno { get;  set; }
        public int SıraNo { get; set; }
        public Islem Islem { get; set; }
        public int OzelSıraNo { get; set; }

    }


}
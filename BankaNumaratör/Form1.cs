using BankaNumaratörVeri;
using System.ComponentModel;
using System.Windows.Forms;

namespace BankaNumaratör
{

    public partial class Form1 : Form
    {



        public static List<Musteri> musteriler = new List<Musteri>()
        {
            new Musteri(){TCno = "100", Islem = Islem.VIP },
            new Musteri(){TCno = "101", Islem = Islem.Bireysel },
            new Musteri(){TCno = "102", Islem = Islem.Bireysel },
            new Musteri(){TCno = "103", Islem = Islem.Gise},
            new Musteri(){TCno = "104", Islem = Islem.Bireysel },
            new Musteri(){TCno = "105", Islem = Islem.Gise },
            new Musteri(){TCno = "106", Islem = Islem.Gise },
            new Musteri(){TCno = "107", Islem = Islem.VIP},
            new Musteri(){TCno = "108", Islem = Islem.Bireysel },
            new Musteri(){TCno = "109", Islem = Islem.Gise },
            new Musteri(){TCno = "110", Islem = Islem.VIP}

        };

        public List<Musteri> sıraBekleyenler = new List<Musteri>();
        public List<Musteri> vipler = new List<Musteri>();
        public List<Musteri> bireyseller = new List<Musteri>();
        public List<Musteri> giseler = new List<Musteri>();
        Musteri musteri;

        public Form1()
        {
            InitializeComponent();

        }


        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            musteri = new Musteri();
            musteri.TCno = txtTCNo.Text;
            BankadaMevcutMüsteriMi();

        }

        private void BankadaMevcutMüsteriMi()
        {
            var bankaMusterisi = musteriler.FirstOrDefault(x => x.TCno == musteri.TCno);
            if (bankaMusterisi != null)
            {
                IslemTurunuKontrolEt(bankaMusterisi); // bankada bu tc noya ait bir müşteri varsa işlem önceliğini kontrol et.
            }
            else
            {
                MessageBox.Show("Girilen T.C. numarasına ait bir müşteri bulunamamaktadır.");
            }


        }


        int vipIslemSayisi = 0;
        int bireyselIslemSayisi = 0;
        int giseIslemSayisi = 0;
        int sıraNo = 0;
        int bireyselSıraNo = 500;
        int vipSıraNo = 1000;
        int giseSıraNo = 200;
        private void IslemTurunuKontrolEt(Musteri musteri) // her gelen musterinin türü kontrol edilir.
        {
            sıraNo++;
            if (sıraBekleyenler == null)
            {

                musteri.SıraNo = sıraNo;
                sıraBekleyenler.Add(musteri);


            }
            else
            {

                if (sıraBekleyenler.Contains(musteri))
                {
                    MessageBox.Show("Girilen T.C. numarasına ait müşteri sıradadır.");
                }
                else
                {
                    if (musteri.Islem == Islem.Gise)
                    {

                        musteri.SıraNo = sıraNo;
                        giseIslemSayisi++;
                        sıraBekleyenler.Add(musteri);
                        giseler.Add(musteri);
                        musteri.OzelSıraNo = giseSıraNo++;
                    }
                    else if (musteri.Islem == Islem.Bireysel)
                    {

                        musteri.SıraNo = sıraNo;
                        bireyselIslemSayisi++;
                        sıraBekleyenler.Add(musteri);
                        bireyseller.Add(musteri);
                        musteri.OzelSıraNo = bireyselSıraNo++;
                    }
                    else
                    {
                        musteri.SıraNo = sıraNo;
                        vipIslemSayisi++;
                        sıraBekleyenler.Add(musteri);
                        vipler.Add(musteri);
                        musteri.OzelSıraNo = vipSıraNo++;
                        if (sıraBekleyenler.Count > 0) // eğer daha önce sıra bekleyen varsa kontrol et.
                        {
                            
                            int yedekSiraNo;
                            for (int i = sıraBekleyenler.Count - 1; i >= 0; i--) // eklenen vip hariç sıradakilerin sonuncusundan başlar ilk eklenene kadar gider
                            {

                                if (sıraBekleyenler[i].Islem != Islem.VIP && sıraBekleyenler[i + 1].SıraNo > sıraBekleyenler[i].SıraNo) // sıra bekleyenlerden vıp öncesinin işlemi VIP değilse ve eklenenin sırası öncekinin sırasında büyükse yer değiştir.
                                {
                                    yedekSiraNo = musteri.SıraNo;
                                    musteri.SıraNo = sıraBekleyenler[i].SıraNo;
                                    sıraBekleyenler[i].SıraNo = yedekSiraNo;

                                }


                            }


                        }


                    }
                }
            }

            sıraBekleyenler = sıraBekleyenler.OrderBy(x => x.SıraNo).ToList();
            dgvSıradakiler.DataSource = sıraBekleyenler;
            dgvSıradakiler.Columns["TCno"].Visible = false;
            IslemSayisiYazdir();
            GiseYazdir(musteri);
        }


        private void GiseYazdir(Musteri sıradakiMusteri)
        {
            IslemYapilanYer gise = new IslemYapilanYer();
            lblYapilanIslem.Text = gise.İslemYapılıyor(sıradakiMusteri);

        }

        private void IslemSayisiYazdir()
        {
            lblVipIslemSayisi.Text = vipIslemSayisi.ToString();
            lblBireyselIslemSayisi.Text = bireyselIslemSayisi.ToString();
            lblGiseIslemSayisi.Text = giseIslemSayisi.ToString();
        }


    }
}
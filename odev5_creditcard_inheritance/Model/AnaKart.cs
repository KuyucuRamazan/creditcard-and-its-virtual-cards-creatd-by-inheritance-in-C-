using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace odev5_creditcard_inheritance
{
    internal class AnaKart : KrediKarti
    {
        public override double Limit { get; set; } = 20000;
        public override double EkLimit { get; set; } = 0;
        public Dictionary<HarcamaTip, KrediKarti> SanalKartlar { get; set; }
        public AnaKart()
        {
            SanalKartlar = new Dictionary<HarcamaTip, KrediKarti>();
            SanalKartlar.Add(HarcamaTip.Giyim, new KrediKarti { Limit = 3500, EkLimit = 800 });
            SanalKartlar.Add(HarcamaTip.Ulasim, new KrediKarti { Limit = 3500, EkLimit = 800 });
            SanalKartlar.Add(HarcamaTip.Yemek, new KrediKarti { Limit = 3500, EkLimit = 800 });
            SanalKartlar.Add(HarcamaTip.Eglence, new KrediKarti { Limit = 3500, EkLimit = 800 });
        }

        public override double HarcamaToplami()
        {
            var harcamaToplami = base.HarcamaToplami();
            foreach (var sanalKart in SanalKartlar.Values)
            {
                harcamaToplami += sanalKart.HarcamaToplami();
            }
            return harcamaToplami;
        }

        public override bool HarcamaYap(HarcamaTip harcamaTip, double toplam)
        {
            var harcamaToplami = HarcamaToplami();
            if (harcamaToplami + toplam > Limit + EkLimit)
                return false;

            if (SanalKartlar.Keys.Contains(harcamaTip))
            {
                var sanalKart = SanalKartlar[harcamaTip];
                return sanalKart.HarcamaYap(harcamaTip, toplam);
            }
            else
            {
                base.HarcamaYap(harcamaTip, toplam);
            }
            return false;
        }

        public override string HesapEkstresi()
        {
            var anakartHesapEkstresi= base.HesapEkstresi();
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("{0} Ekstresi", HarcamaTip.Diger.ToString()));
            sb.AppendLine();
            sb.AppendLine(anakartHesapEkstresi);
            sb.AppendLine();

            foreach (var sanalKart in SanalKartlar)
            {
                sb.Append(string.Format("{0} Ekstresi", sanalKart.Key.ToString()));
                sb.AppendLine();
                var sanalKartEkstresi = sanalKart.Value.HesapEkstresi();
                sb.AppendLine(sanalKartEkstresi);
                sb.AppendLine();
            }


            sb.Append(string.Format("Toplam : {0}", HarcamaToplami()));

            return sb.ToString();
        }
    }
}

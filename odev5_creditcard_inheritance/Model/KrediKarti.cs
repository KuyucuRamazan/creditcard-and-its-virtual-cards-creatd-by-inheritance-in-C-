using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5_creditcard_inheritance
{
    internal class KrediKarti
    {
        public virtual double Limit { get; set; }

        public virtual double EkLimit { get; set; }
        public List<Harcama> HarcamaGecmisi { get; set; } = new List<Harcama>();

        public virtual double HarcamaToplami()
        {
            double toplam = 0d;
            foreach (var harcama in HarcamaGecmisi)
            {
                toplam += harcama.Toplam;
            }
            return toplam;
        }

        public virtual bool HarcamaYap(HarcamaTip harcamaTip, double toplam)
        {
            var harcamaToplami = HarcamaToplami();
            if (Limit + EkLimit > harcamaToplami + toplam)
            {
                HarcamaGecmisi.Add(new Harcama { HarcamaTip = harcamaTip, Toplam = toplam });
                return true;
            }

            return false;
        }

        public virtual string HesapEkstresi() {
            StringBuilder sb = new StringBuilder();
            foreach (var harcama in HarcamaGecmisi)
            {
                sb.Append(string.Format("Harcama Tipi : {0} Toplam : {1}", harcama.HarcamaTip.ToString(), harcama.Toplam));
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

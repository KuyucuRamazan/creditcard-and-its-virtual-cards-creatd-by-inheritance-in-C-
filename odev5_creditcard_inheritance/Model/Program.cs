using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5_creditcard_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var krediKart = new AnaKart();            
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 1000);
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 5000);
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 6000);
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 8000);
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 3000);
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 200);
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 900);
            krediKart.HarcamaYap(HarcamaTip.Ulasim, 700);
            krediKart.HarcamaYap(HarcamaTip.Eglence, 1000);
            krediKart.HarcamaYap(HarcamaTip.Eglence, 1000);
            krediKart.HarcamaYap(HarcamaTip.Eglence, 1000);
            krediKart.HarcamaYap(HarcamaTip.Eglence, 900);
            krediKart.HarcamaYap(HarcamaTip.Yemek, 1000);
            krediKart.HarcamaYap(HarcamaTip.Yemek, 2000);
            krediKart.HarcamaYap(HarcamaTip.Yemek, 500);
            krediKart.HarcamaYap(HarcamaTip.Yemek, 900);
            krediKart.HarcamaYap(HarcamaTip.Giyim, 1000);
            krediKart.HarcamaYap(HarcamaTip.Giyim, 2000);
            krediKart.HarcamaYap(HarcamaTip.Giyim, 500);
            krediKart.HarcamaYap(HarcamaTip.Giyim, 500);
            krediKart.HarcamaYap(HarcamaTip.Giyim, 900);
            krediKart.HarcamaYap(HarcamaTip.Diger, 900);
            krediKart.HarcamaYap(HarcamaTip.Diger, 900);
            krediKart.HarcamaYap(HarcamaTip.Diger, 900);
            krediKart.HarcamaYap(HarcamaTip.Diger, 900);
            krediKart.HarcamaYap(HarcamaTip.Diger, 900);


            Console.WriteLine(krediKart.HesapEkstresi());
            Console.ReadLine();
        }
    }
}

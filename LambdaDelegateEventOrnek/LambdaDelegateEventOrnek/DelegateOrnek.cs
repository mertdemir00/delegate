using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDelegateEventOrnek
{
    public class DelegateOrnek
    {
        delegate int TamSayiIslevi(int sayi1, int sayi2);
        TamSayiIslevi tsiTopla = (x,y) => x + y;
        TamSayiIslevi tsiCikar = (x,y) => x - y;

        public void Yazdir()
        {
            int toplam = tsiTopla(5, 2);
            Console.WriteLine("Toplam:" + toplam);
            int cikan = tsiCikar(5, 2);
            Console.WriteLine("Kalan:" + cikan);
        }
    }
}

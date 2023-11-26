using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Name);
        }

        public void Ekle2(string name, string description, double price)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + name);
        }
    }
}

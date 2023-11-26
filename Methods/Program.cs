using Methods;
using System;

namespace KampIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Name = "Elma";
            urun1.Price = 15;
            urun1.Description = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Name = "Karpuz";
            urun2.Price = 80;
            urun2.Description = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Description);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("--------------Metotlar----------------");
            
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil armut",12);
        }
    }
}
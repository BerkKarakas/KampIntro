using System;

namespace Alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Takim takim1 = new Takim();
            takim1.takimAdi = "Real Madrid";
            takim1.ulkeAdi = "İspanya";
            takim1.puan = 18;

            Takim takim2 = new Takim();
            takim2.takimAdi = "Liverpool";
            takim2.ulkeAdi = "İngiltere";
            takim2.puan = 12;

            Takim takim3 = new Takim();
            takim3.takimAdi = "Juventus";
            takim3.ulkeAdi = "İtalya";
            takim3.puan = 6;

            Takim[] takimlar = new Takim[] {takim1,takim2,takim3 };

            foreach (Takim takim in takimlar)
            {
                Console.WriteLine(takim.takimAdi + " " + takim.ulkeAdi + "'yı temsil ederek " + takim.puan + " topladı");
            }

        }
    }

    class Takim
    {
        public string takimAdi { get; set; }
        public string ulkeAdi { get; set; }
        public int puan { get; set; }
    }

}

using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array(dizi)lerde tutarız

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç için Temel Kurs", "Java","Python","C#" };
            


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}

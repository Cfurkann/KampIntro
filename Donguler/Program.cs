using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programalamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programalamaya başlangıç için temel kurs","Java","Python","C#" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);                                               
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}

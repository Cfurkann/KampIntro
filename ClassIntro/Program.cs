using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Güler";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Sinan Altın";
            kurs3.IzlenmeOrani = 76;

            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

using System;

namespace modul3_1302204047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new PosisiKarakterGame();
            game.printStatus();
            game.setKarakter(Karakter.Jongkok);
            game.printStatus();
            game.setKarakter(Karakter.Terbang);
            game.printStatus();

            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Apel));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Aprikot));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Alpukat));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Pisang));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Paprika));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Blackberry));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Ceri));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Kelapa));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Jagung));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Kurma));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Durian));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Anggur));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Melon));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Semangka));

      

        }
    }
}
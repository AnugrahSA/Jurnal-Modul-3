using System;

public enum Karakter
{
	Berdiri,
	Jongkok,
	Tengkurap,
	Terbang,
}

public enum Tombol
{
	TombolS,
	TombolX,
	TombolW,
}

public class PosisiKarakterGame
{
	private Karakter karakter = Karakter.Berdiri;

	public void setKarakter(Karakter karakter)
    {
		this.karakter = karakter;
    }

	public void printStatus()
    {
        switch (this.karakter)
        {
			case Karakter.Jongkok:
				Console.WriteLine("Posisi landing");
				break;
			case Karakter.Terbang:
				Console.WriteLine("Posisi take off");
				break;

		}
    }


}

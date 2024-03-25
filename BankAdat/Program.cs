using System;

class Program
{
    static void Main()
    {
        Bankkartya bankkartya = new Bankkartya("Kelemen Lajos", "3225636263", new DateTime(2025, 03, 12), 100000);
        bankkartya.KartyaAdataiKiiras();
        bankkartya.PenzFelvetel(5000);
        bankkartya.KartyaAdataiKiiras();
    }
}
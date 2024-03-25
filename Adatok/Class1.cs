using System;

public class Bankkartya
{
    public string OwnerName { get; set; }
    public string CardNumber { get; set; }
    public DateTime ExperitationDate { get; set; }
    public int Balance { get; set; }

    public Bankkartya(string ownername, string cardnumber, DateTime experitationdate, int balance)
    {
        OwnerName = ownername;
        CardNumber = cardnumber;
        ExperitationDate = experitationdate;
        Balance = balance;
    }
    public void PenzFelvetel(int osszeg)
    {
        int Balance = 0;
        if (osszeg > 0 && osszeg <= Balance)
        {
            Balance -= osszeg;
            Console.WriteLine($"Sikeres pénzfelvétel: {osszeg} Ft");
        }
        else
        {
            Console.WriteLine("Nem sikerült a pénzfelvétel. Hibás összeg vagy nincs elegendő egyenleg.");
        }
    }
    public void KartyaAdataiKiiras()
    {
        Console.WriteLine($"Tulajdonos neve: {OwnerName}");
        Console.WriteLine($"Kártyaszám: {CardNumber}");
        Console.WriteLine($"Lejárati dátum: {ExperitationDate}");
        Console.WriteLine($"Egyenleg: {Balance} Ft");
    }
}
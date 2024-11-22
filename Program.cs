string dobitnaKombinacija = "";
Random random = new Random();
for (int brojcanik = 0; brojcanik < 7; brojcanik++)
{
    int randomBroj = random.Next(1, 9);
    dobitnaKombinacija += randomBroj;
}

string unioKorisnik = string.Empty; //""
int brojPogodjenihBrojeva = 0;
Console.WriteLine("Unesi 7 znameniki za loto: ");
unioKorisnik = Console.ReadLine();
for (int i = 0; i < unioKorisnik.Length; i++)
{
    if (unioKorisnik[i] == dobitnaKombinacija[i])
    {
       brojPogodjenihBrojeva++;
    }

}

if (brojPogodjenihBrojeva == dobitnaKombinacija.Length)
{
    Console.WriteLine("Dobitak!");
}
else
{
    Console.WriteLine("Kombinacija nije dobitna!");
}
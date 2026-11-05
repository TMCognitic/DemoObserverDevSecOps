using CollectionTools;
using DemoObserverDevSecOps.Models;

Produit chocomel = new Produit("Chocomel", 1.35);
Produit toxique = new Produit("Toxique", 1000);

Acheteur gwen = new Acheteur("Gwendoline");
Acheteur thierry = new Acheteur("Thierry");
chocomel.NotifyHandler += gwen.Reagit;
chocomel.NotifyHandler += thierry.Reagit;

chocomel.Prix = 1.3;

chocomel.NotifyHandler -= gwen.Reagit;

chocomel.Prix = 1.2;
Console.WriteLine();

int[] dentier = Enumerable.Range(0, 10).ToArray();

IEnumerable<int> evens = MyEnumerable.MyWhere(dentier, delegate(int x) { return x % 2 is 0; });

foreach(int i in evens)
    Console.WriteLine(i);
Console.WriteLine();

IEnumerable<int> odds = MyEnumerable.MyWhere(dentier, (x) => x % 2 is not 0);

foreach (int i in odds)
    Console.WriteLine(i);
Console.WriteLine();

IEnumerable<string> primes = dentier.MyWhere(IsPrime).MySelect(x => $"{x} est premier");

foreach (string i in primes)
    Console.WriteLine(i);

bool IsPrime(int i)
{
    if (i < 2)
        return false;

    int sqrt = (int)Math.Sqrt(i);

    for (int diviseur = 2; diviseur <= sqrt; diviseur++)
    {
        if(i % diviseur is 0)
        {
            return false;
        }
    }

    return true;
}



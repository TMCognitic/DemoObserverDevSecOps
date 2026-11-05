using DemoObserverDevSecOps.Patterns.ObserverPattern;

namespace DemoObserverDevSecOps.Models
{
    public class Acheteur(string nom)
    {
        public string Nom { get; } = nom;

        public void Reagit(ISubject subject)
        {
            if(subject is Produit p)
            {
                Console.WriteLine($"{Nom} signale que le produit '{p.Nom}' change de prix : {p.Prix}");
            }
        }
    }
}

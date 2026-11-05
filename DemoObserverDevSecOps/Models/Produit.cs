using DemoObserverDevSecOps.Patterns.ObserverPattern;

namespace DemoObserverDevSecOps.Models
{
    public class Produit(string nom, double prix) : Subject
    {
        public string Nom { get; } = nom;

        public double Prix
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    Notify();
                }
            }
        } = prix;
    }
}

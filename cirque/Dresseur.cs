namespace cirque;

public class Dresseur
{
    public string Nom { get; private set; }
    private Singe singe;

    public Dresseur(string nom, Singe singe)
    {
        Nom = nom;
        this.singe = singe;
    }
    
    public void DemanderTour(int index)
    {
        Console.WriteLine($"{Nom} demande à {singe.Nom} d'effectuer un tour...");
        Tour tour = singe.ChoisirTour(index);
        tour.EffectuerTour();
        Reagir(tour);
    }
    
    private void Reagir(Tour tour)
    {
        if (tour is Acrobatie)
        {
            Console.WriteLine("Le spectateur applaudit !");
        }
        else if (tour is Musique)
        {
            Console.WriteLine("Le spectateur siffle.");
        }
    }
    
    
}

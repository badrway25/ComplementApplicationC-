namespace cirque;

public class Singe
{
    public string Nom { get; private set; }
    private List<Tour> tours;

    public Singe(string nom, List<Tour> tours)
    {
        Nom = nom;
        this.tours = tours;
    }
    
    public Tour ChoisirTour(int index)
    {
        return tours[index];
    }

    public void AfficherTours()
    {
        for (int i = 0; i < tours.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tours[i].Nom}");
        }
    }
    
    
}

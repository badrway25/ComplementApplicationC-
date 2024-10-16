namespace cirque;

public class Musique : Tour
{
    public Musique(string nom)
    {
        Nom = nom;
    }

    public override void EffectuerTour()
    {
        Console.WriteLine($"Le singe joue un morceau de musique : {Nom}.");
    }
}
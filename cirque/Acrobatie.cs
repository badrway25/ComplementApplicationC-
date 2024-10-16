namespace cirque;

public class Acrobatie: Tour
{
    public Acrobatie(string nom)
    {
        Nom = nom;
    }

    public override void EffectuerTour()
    {
        Console.WriteLine($"Le singe effectue une acrobatie : {Nom} !");
    }
}

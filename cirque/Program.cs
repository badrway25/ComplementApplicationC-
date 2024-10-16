using cirque;

class Program
    {
        static void Main(string[] args)
        {
            
            List<Tour> toursSinge1 = new List<Tour>
            {
                new Acrobatie("Acrobatie aérienne"),
                new Musique("Sifflet musical"),
                new Acrobatie("Déplacement acrobatique sur les mains")
            };

            List<Tour> toursSinge2 = new List<Tour>
            {
                new Musique("Cymbales à main"),
                new Acrobatie("Saut mortel"),
                new Musique("Flûte ensorcelée")
            };

            // Création des singes
            Singe singe1 = new Singe("Toto", toursSinge1);
            Singe singe2 = new Singe("Tata", toursSinge2);

            // Création des dresseurs
            Dresseur dresseur1 = new Dresseur("Jean", singe1);
            Dresseur dresseur2 = new Dresseur("Said", singe2);

            bool continuer = true;
            while (continuer)
            {
                Console.WriteLine("\n****** Cirque des Singes ******");
                Console.WriteLine("1. Jean demande à Toto d'exécuter un tour.");
                Console.WriteLine("2. Said demande à Tata d'exécuter un tour.");
                Console.WriteLine("3. Quitter.");
                Console.Write("Votre option : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Console.WriteLine("\nToto connaît les tours suivants :");
                        singe1.AfficherTours();
                        Console.Write("Choisissez un tour (1-3) : ");
                        int tourIndex1 = int.Parse(Console.ReadLine()) - 1;
                        dresseur1.DemanderTour(tourIndex1);
                        break;

                    case "2":
                        Console.WriteLine("\nTata connaît les tours suivants :");
                        singe2.AfficherTours();
                        Console.Write("Choisissez un tour (1-3) : ");
                        int tourIndex2 = int.Parse(Console.ReadLine()) - 1;
                        dresseur2.DemanderTour(tourIndex2);
                        break;

                    case "3":
                        continuer = false;
                        break;

                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }
            }

            Console.WriteLine("Merci pour votre participation au spectacle !");
        }
    }

public class HotelIHM : IHotelIHM
{
    private readonly IHotelService _hotelService;

    public HotelIHM(IHotelService hotelService)
    {
        _hotelService = hotelService;
    }

    private void GérerHôtel()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Gestion de l'hôtel");
            Console.WriteLine("1. Afficher le résumé de l'hôtel");
            Console.WriteLine("2. Gérer les services de l'hôtel");
            Console.WriteLine("3. Statistiques de l'hôtel");
            Console.WriteLine("4. Retour au menu principal");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AfficherRésuméHôtel();
                    break;
                case "2":
                    GérerServicesHôtel();
                    break;
                case "3":
                    AfficherStatistiquesHôtel();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
        }
    }

    private void AfficherRésuméHôtel()
    {
        Console.WriteLine("Résumé de l'Hôtel :");
        Console.WriteLine("Nombre total de chambres : ...");
        Console.WriteLine("Nombre de chambres occupées : ...");
        Console.WriteLine("Nombre de réservations en cours : ...");
    }


    private void GérerServicesHôtel()
    {
        Console.WriteLine("Gestion des Services de l'Hôtel");
        Console.WriteLine("1. Ajouter un service");
        Console.WriteLine("2. Modifier un service");
        Console.WriteLine("3. Supprimer un service");
    }


    private void AfficherStatistiquesHôtel()
    {
        Console.WriteLine("Statistiques de l'Hôtel :");
        Console.WriteLine("Taux d'occupation : ...");
        Console.WriteLine("Revenus moyens par chambre : ...");
    }
}

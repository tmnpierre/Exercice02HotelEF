public class HotelIHM : IHotelIHM
{
    private readonly IHotelService _hotelService;

    public HotelIHM(IHotelService hotelService)
    {
        _hotelService = hotelService;
    }

    private void G�rerH�tel()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Gestion de l'h�tel");
            Console.WriteLine("1. Afficher le r�sum� de l'h�tel");
            Console.WriteLine("2. G�rer les services de l'h�tel");
            Console.WriteLine("3. Statistiques de l'h�tel");
            Console.WriteLine("4. Retour au menu principal");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AfficherR�sum�H�tel();
                    break;
                case "2":
                    G�rerServicesH�tel();
                    break;
                case "3":
                    AfficherStatistiquesH�tel();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez r�essayer.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
        }
    }

    private void AfficherR�sum�H�tel()
    {
        Console.WriteLine("R�sum� de l'H�tel :");
        Console.WriteLine("Nombre total de chambres : ...");
        Console.WriteLine("Nombre de chambres occup�es : ...");
        Console.WriteLine("Nombre de r�servations en cours : ...");
    }


    private void G�rerServicesH�tel()
    {
        Console.WriteLine("Gestion des Services de l'H�tel");
        Console.WriteLine("1. Ajouter un service");
        Console.WriteLine("2. Modifier un service");
        Console.WriteLine("3. Supprimer un service");
    }


    private void AfficherStatistiquesH�tel()
    {
        Console.WriteLine("Statistiques de l'H�tel :");
        Console.WriteLine("Taux d'occupation : ...");
        Console.WriteLine("Revenus moyens par chambre : ...");
    }
}

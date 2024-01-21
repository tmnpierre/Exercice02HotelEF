public class ReservationsIHM : IRéservationIHM
{
    private readonly IRéservationService _réservationService;

    public ReservationsIHM(IRéservationService réservationService)
    {
        _réservationService = réservationService;
    }

    private void GérerRéservations()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Gestion des réservations");
            Console.WriteLine("1. Ajouter une réservation");
            Console.WriteLine("2. Afficher les réservations");
            Console.WriteLine("3. Modifier une réservation");
            Console.WriteLine("4. Supprimer une réservation");
            Console.WriteLine("5. Retour au menu principal");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterRéservation();
                    break;
                case "2":
                    AfficherRéservations();
                    break;
                case "3":
                    ModifierRéservation();
                    break;
                case "4":
                    SupprimerRéservation();
                    break;
                case "5":
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

    private void AjouterRéservation()
    {
        Console.Write("Entrez l'ID du client pour la réservation : ");
        var clientId = int.Parse(Console.ReadLine());
        Console.WriteLine("Réservation ajoutée avec succès.");
    }


    private void AfficherRéservations()
    {
        foreach (var réservation in réservations)
        {
            Console.WriteLine($"ID: {réservation.RéservationId}, Client ID: {réservation.ClientId}, ...");
        }
    }


    private void ModifierRéservation()
    {
        Console.Write("Entrez l'ID de la réservation à modifier : ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("Réservation modifiée avec succès.");
    }


    private void SupprimerRéservation()
    {
        Console.Write("Entrez l'ID de la réservation à supprimer : ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("Réservation supprimée avec succès.");
    }
}

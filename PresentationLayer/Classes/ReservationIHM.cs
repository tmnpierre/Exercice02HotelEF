public class ReservationsIHM : IR�servationIHM
{
    private readonly IR�servationService _r�servationService;

    public ReservationsIHM(IR�servationService r�servationService)
    {
        _r�servationService = r�servationService;
    }

    private void G�rerR�servations()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Gestion des r�servations");
            Console.WriteLine("1. Ajouter une r�servation");
            Console.WriteLine("2. Afficher les r�servations");
            Console.WriteLine("3. Modifier une r�servation");
            Console.WriteLine("4. Supprimer une r�servation");
            Console.WriteLine("5. Retour au menu principal");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterR�servation();
                    break;
                case "2":
                    AfficherR�servations();
                    break;
                case "3":
                    ModifierR�servation();
                    break;
                case "4":
                    SupprimerR�servation();
                    break;
                case "5":
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

    private void AjouterR�servation()
    {
        Console.Write("Entrez l'ID du client pour la r�servation : ");
        var clientId = int.Parse(Console.ReadLine());
        Console.WriteLine("R�servation ajout�e avec succ�s.");
    }


    private void AfficherR�servations()
    {
        foreach (var r�servation in r�servations)
        {
            Console.WriteLine($"ID: {r�servation.R�servationId}, Client ID: {r�servation.ClientId}, ...");
        }
    }


    private void ModifierR�servation()
    {
        Console.Write("Entrez l'ID de la r�servation � modifier : ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("R�servation modifi�e avec succ�s.");
    }


    private void SupprimerR�servation()
    {
        Console.Write("Entrez l'ID de la r�servation � supprimer : ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("R�servation supprim�e avec succ�s.");
    }
}

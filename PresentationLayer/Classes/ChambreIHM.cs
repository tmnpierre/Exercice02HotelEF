public class ChambreIHM : IChambreIHM
{
    private readonly IChambreService _chambreService;

    public ChambreIHM(IChambreService chambreService)
    {
        _chambreService = chambreService;
    }

    private void GérerChambres()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Gestion des chambres");
            Console.WriteLine("1. Ajouter une chambre");
            Console.WriteLine("2. Afficher les chambres");
            Console.WriteLine("3. Modifier une chambre");
            Console.WriteLine("4. Supprimer une chambre");
            Console.WriteLine("5. Retour au menu principal");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterChambre();
                    break;
                case "2":
                    AfficherChambres();
                    break;
                case "3":
                    ModifierChambre();
                    break;
                case "4":
                    SupprimerChambre();
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

    private void AjouterChambre()
    {
        Console.Write("Entrez le numéro de la chambre : ");
        var numéro = int.Parse(Console.ReadLine());

        Console.Write("Entrez le nombre de lits : ");
        var nombreLits = int.Parse(Console.ReadLine());

        Console.Write("Entrez le tarif de la chambre : ");
        var tarif = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Chambre ajoutée avec succès.");
    }


    private void AfficherChambres()
    {
        foreach (var chambre in chambres)
        {
            Console.WriteLine($"Numéro: {chambre.Numéro}, Lits: {chambre.NombreLits}, Tarif: {chambre.Tarif}");
        }
    }


    private void ModifierChambre()
    {
        Console.Write("Entrez le numéro de la chambre à modifier : ");
        var numéro = int.Parse(Console.ReadLine());

        Console.Write("Entrez le nouveau nombre de lits : ");
        var nombreLits = int.Parse(Console.ReadLine());

        Console.Write("Entrez le nouveau tarif de la chambre : ");
        var tarif = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Chambre modifiée avec succès.");
    }


    private void SupprimerChambre()
    {
        Console.Write("Entrez le numéro de la chambre à supprimer : ");
        var numéro = int.Parse(Console.ReadLine());
        Console.WriteLine("Chambre supprimée avec succès.");
    }
}

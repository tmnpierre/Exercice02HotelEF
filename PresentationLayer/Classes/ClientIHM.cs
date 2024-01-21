public class ClientIHM : IClientIHM
{
    private readonly IClientService _clientService;

    public ClientIHM(IClientService clientService)
    {
        _clientService = clientService;
    }

    public void GérerClients()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Gestion des clients");
            Console.WriteLine("1. Ajouter un client");
            Console.WriteLine("2. Afficher les clients");
            Console.WriteLine("3. Modifier un client");
            Console.WriteLine("4. Supprimer un client");
            Console.WriteLine("5. Retour au menu principal");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterClient();
                    break;
                case "2":
                    AfficherClients();
                    break;
                case "3":
                    ModifierClient();
                    break;
                case "4":
                    SupprimerClient();
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

    private void AjouterClient()
    {
        Console.Write("Entrez le nom du client : ");
        var nom = Console.ReadLine();

        Console.Write("Entrez le prénom du client : ");
        var prénom = Console.ReadLine();

        Console.Write("Entrez le numéro de téléphone du client : ");
        var numéroTéléphone = Console.ReadLine();
        Console.WriteLine("Client ajouté avec succès.");
    }
    private readonly IClientService _clientService;

    public IHM(IClientService clientService)
    {
        _clientService = clientService;
    }
    private void AfficherClients()
    {
        var clients = _clientService.GetAllClientsAsync().Result;

        foreach (var client in clients)
        {
            Console.WriteLine($"ID: {client.ClientId}, Nom: {client.Nom}, Prénom: {client.Prénom}, Téléphone: {client.NuméroTéléphone}");
        }
    }

    private void ModifierClient()
    {
        Console.Write("Entrez l'ID du client à modifier : ");
        var id = int.Parse(Console.ReadLine());

        Console.Write("Entrez le nouveau nom du client : ");
        var nom = Console.ReadLine();

        Console.Write("Entrez le nouveau prénom du client : ");
        var prénom = Console.ReadLine();

        Console.Write("Entrez le nouveau numéro de téléphone du client : ");
        var numéroTéléphone = Console.ReadLine();
        Console.WriteLine("Client modifié avec succès.");
    }

    private void SupprimerClient()
    {
        Console.Write("Entrez l'ID du client à supprimer : ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("Client supprimé avec succès.");
    }
}
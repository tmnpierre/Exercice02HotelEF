public class ClientIHM : IClientIHM
{
    private readonly IClientService _clientService;

    public ClientIHM(IClientService clientService)
    {
        _clientService = clientService;
    }

    public void G�rerClients()
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

    private void AjouterClient()
    {
        Console.Write("Entrez le nom du client : ");
        var nom = Console.ReadLine();

        Console.Write("Entrez le pr�nom du client : ");
        var pr�nom = Console.ReadLine();

        Console.Write("Entrez le num�ro de t�l�phone du client : ");
        var num�roT�l�phone = Console.ReadLine();
        Console.WriteLine("Client ajout� avec succ�s.");
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
            Console.WriteLine($"ID: {client.ClientId}, Nom: {client.Nom}, Pr�nom: {client.Pr�nom}, T�l�phone: {client.Num�roT�l�phone}");
        }
    }

    private void ModifierClient()
    {
        Console.Write("Entrez l'ID du client � modifier : ");
        var id = int.Parse(Console.ReadLine());

        Console.Write("Entrez le nouveau nom du client : ");
        var nom = Console.ReadLine();

        Console.Write("Entrez le nouveau pr�nom du client : ");
        var pr�nom = Console.ReadLine();

        Console.Write("Entrez le nouveau num�ro de t�l�phone du client : ");
        var num�roT�l�phone = Console.ReadLine();
        Console.WriteLine("Client modifi� avec succ�s.");
    }

    private void SupprimerClient()
    {
        Console.Write("Entrez l'ID du client � supprimer : ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("Client supprim� avec succ�s.");
    }
}
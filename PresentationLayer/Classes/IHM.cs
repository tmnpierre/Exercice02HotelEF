public class IHM : IIHM
{
    public void Lancer()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans le système de gestion d'hôtel");
            Console.WriteLine("1. Gérer les clients");
            Console.WriteLine("2. Gérer les chambres");
            Console.WriteLine("3. Gérer les réservations");
            Console.WriteLine("4. Gérer l'hôtel");
            Console.WriteLine("5. Quitter");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    GérerClients();
                    break;
                case "2":
                    GérerChambres();
                    break;
                case "3":
                    GérerRéservations();
                    break;
                case "4":
                    GérerHôtel();
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

    private void GérerClients()
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

public class IHM : IIHM
{
    private readonly IClientIHM _clientIHM;
    private readonly IChambreIHM _chambreIHM;
    private readonly IRéservationIHM _réservationIHM;
    private readonly IHotelIHM _hotelIHM;

    public IHM(IClientIHM clientIHM, IChambreIHM chambreIHM, IRéservationIHM réservationIHM, IHotelIHM hotelIHM)
    {
        _clientIHM = clientIHM;
        _chambreIHM = chambreIHM;
        _réservationIHM = réservationIHM;
        _hotelIHM = hotelIHM;
    }

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
                    _clientIHM.GérerClients();
                    break;
                case "2":
                    _chambreIHM.GérerChambres();
                    break;
                case "3":
                    _réservationIHM.GérerRéservations();
                    break;
                case "4":
                    _hotelIHM.GérerHôtel();
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
}

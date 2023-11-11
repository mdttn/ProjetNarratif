namespace ProjetNarratif.Rooms
{
    internal class Room1 : Room
    {
        internal override string CreateDescription() =>
@"La chambre est en désordre.
Les murs sont roses.
Il y a des toutous sur le [l]it et du maquillage sur le [b]ureau.
Hélène a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [c]orridor.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "brosse":
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 8.");
                    break;
                case "origami":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "cahier":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "pinceau":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "l":

                    break;
                case "b":

                    break;
                case "c":
                    Console.WriteLine("Tu retournes dans le corridor.");
                    Game.Transition<Floor1>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

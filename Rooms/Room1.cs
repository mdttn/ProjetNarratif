namespace ProjetNarratif.Rooms
{
    internal class Room1 : Room
    {
        internal override string CreateDescription() =>
@"La chambre est en désordre.
Il y a des toutous sur le lit.
Les murs sont roses et il y a du maquillage sur le bureau.
L'élève qui réside dans cette chambre a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [corridor].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "brosse":
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 8.");
                    break;
                case "corridor":
                    Console.WriteLine("Tu retournes dans le corridor.");
                    Game.Transition<Floor1>();
                    break;
                default:
                    Console.WriteLine("Ce n'est pas le sien.");
                    break;
            }
        }
    }
}

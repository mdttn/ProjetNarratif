namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal static bool vapeur;

        internal override string CreateDescription() =>
@"Dans la toilette, le [bain] est rempli d'eau chaude.
Le [miroir] devant toi affiche ton visage déprimé.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu te laisses relaxer dans le bain et la vapeur monte.");
                    vapeur = true;
                    break;
                case "miroir":
                    if (vapeur)
                    {
                        Console.WriteLine("Tu aperçois les chiffres 0832 écrits sur la brume sur le miroir.");
                    }
                    else
                    {
                        Console.WriteLine("Ton visage apparaît sur le miroir.");
                    }
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

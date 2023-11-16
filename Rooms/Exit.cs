namespace ProjetNarratif.Rooms
{
    internal class Exit : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"La porte est verrouillée avec un code [????].
Tu peux te retourner vers le reste de l'[é]tage.

Tu as une [liste] d'objets perdus que tu as ramassés.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "8526":
                    Console.WriteLine("La porte s'ouvre et tu sors dehors.");
                    Game.Finish();
                    break;
                case "é":
                    Console.WriteLine("Tu te retournes face aux chambres.");
                    Game.Transition<Floor1>();
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets perdus:");
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

namespace ProjetNarratif.Rooms
{
    internal class Exit : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"La porte est verrouillée avec un code [????].
Tu peux te retourner vers le reste de l'[étage].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "8526":
                    Console.WriteLine("La porte s'ouvre et tu sors dehors.");
                    Game.Finish();
                    break;
                case "étage":
                    Console.WriteLine("Tu te retournes face aux chambres.");
                    Game.Transition<Floor1>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

﻿namespace ProjetNarratif.Rooms
{
    internal class Exit : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"La porte blanche est verrouillée avec un code: [????].
Tu peux te [r]etourner.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "7413":
                    Console.WriteLine("La porte s'ouvre et tu sors.");
                    Game.Finish();
                    break;
                case "r":
                    Console.WriteLine("Tu te retournes face aux chambres.");
                    Game.Transition<Floor1>();
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets:");
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "clés":
                    Console.WriteLine("Boîte de clés:");
                    foreach (var key in Game.box1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("- " + key);
                        Console.ResetColor();
                    }
                    foreach (var key in Game.box2)
                    {
                        Console.WriteLine("- " + key);
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

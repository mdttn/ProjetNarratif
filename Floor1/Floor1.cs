namespace ProjetNarratif.Rooms
{
    internal class Floor1 : Room
    {
        internal override string CreateDescription() =>
@"Tu es au premier étage.
Devant toi, il y a les chambres [11], [12], [13] et [14].
À ta droite, il y a un [e]scalier menant au 2e étage.
À ta gauche, il y a la salle d'entraînement, verrouillée avec un code [????], et une [t]oilette.
Derrière toi, il y a une [p]orte pour sortir du dortoir.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "11":
                    Console.WriteLine("Tu entres dans la première chambre.");
                    Game.Transition<Room11>();
                    break;
                case "12":
                    Console.WriteLine("Tu entres dans la deuxième chambre.");
                    Game.Transition<Room12>();
                    break;
                case "13":
                    Console.WriteLine("Tu entres dans la troisième chambre.");
                    Game.Transition<Room13>();
                    break;
                case "14":
                    Console.WriteLine("Tu entres dans la quatrième chambre.");
                    Game.Transition<Room14>();
                    break;
                case "e":
                    if (Game.pinceau)
                    {
                        Console.WriteLine("Tu montes des marches.");
                    }
                    else
                    {
                        Console.WriteLine("Tu montes des marches et tu trouves un [pinceau].");
                    }
                    Game.Transition<Floor2>();
                    break;
                case "8526":
                    Console.WriteLine("Tu déverrouilles la salle d'entraînement et tu y entres.");
                    Game.Transition<Gym>();
                    break;
                case "t":
                    Console.WriteLine("Tu entres dans la toilette.");
                    Game.Transition<Bathroom>();
                    break;
                case "p":
                    Console.WriteLine("Tu te tournes vers la porte.");
                    Game.Transition<Exit>();
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets perdus:");
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "clés":
                    Console.WriteLine("Boîte de clés:");
                    foreach (var key in Game.box)
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

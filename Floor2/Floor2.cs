namespace ProjetNarratif.Rooms
{
    internal class Floor2 : Room
    {
        internal override string CreateDescription() =>
@"Tu es au deuxième étage.
Devant toi, il y a les chambres [21], [22], [23] et [24].
À ta droite, il y a un [e]scalier menant au 1er étage.
À ta gauche, il y a la [b]ibliothèque et une toilette.
Derrière toi, il y a des fenêtres.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "21":
                    Console.WriteLine("Tu entres dans la première chambre.");
                    Game.Transition<Room21>();
                    break;
                case "22":
                    Console.WriteLine("Tu entres dans la deuxième chambre.");
                    Game.Transition<Room22>();
                    break;
                case "23":
                    Console.WriteLine("Tu entres dans la troisième chambre.");
                    Game.Transition<Room23>();
                    break;
                case "24":
                    Console.WriteLine("Tu entres dans la quatrième chambre.");
                    Game.Transition<Room24>();
                    break;
                case "pinceau":
                    if (!Game.pinceau)
                    {
                        Game.pinceau = true;
                        Game.inventory.Add("pinceau");
                        Console.WriteLine("Tu as ramassé le pinceau.");
                    }
                    else
                    {
                        Console.WriteLine("Tu as déjà ramassé le pinceau.");
                    }
                    break;
                case "e":
                    Console.WriteLine("Tu descends des marches.");
                    Game.Transition<Floor1>();
                    break;
                case "b":
                    Console.WriteLine("Tu entres dans la bibliothèque.");
                    Game.Transition<Library>();
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

namespace ProjetNarratif.Rooms
{
    internal class Room21 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.room21)
            {
                return
@"La chambre est en désordre.
La garde-robe est remplie de vêtements.
Il y a un mannequin au coin de la chambre et à côté du [b]ureau.
Diana a retrouvé son béret.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"La chambre est en désordre.
La garde-robe est remplie de vêtements.
Il y a un mannequin au coin de la chambre et à côté du [b]ureau.
Diana a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "béret":
                    Game.room21 = true;
                    if (Game.inventory.Contains("béret"))
                    {
                        Game.inventory.Remove("béret");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 7.");
                        Game.box2.Add("chambre 21: #7");
                    }
                    else
                    {
                        Console.WriteLine("Elle a déjà retrouvé son béret.");
                    }
                    break;
                case "brosse":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
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
                case "parapluie":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "craie en poudre":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "calculatrice":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "b":
                    Console.WriteLine("Il y a une machine à coudre et un miroir sur le bureau.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 21.");
                    Game.Transition<Floor2>();
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

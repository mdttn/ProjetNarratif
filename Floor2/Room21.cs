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

Tu as une [liste] d'objets que tu as ramassés.
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

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "béret":
                    if (Game.inventory.Contains("béret"))
                    {
                        Game.room21 = true;
                        Game.inventory.Remove("béret");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 7.");
                        Game.box2.Add("chambre 21: #7");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "brosse":
                    if (!Game.room21)
                    {
                        if (Game.inventory.Contains("brosse"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...");
                            Game.HPLoss();
                        }
                        else
                        {
                            Console.WriteLine("Commande invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "origami":
                    if (!Game.room21)
                    {
                        if (Game.inventory.Contains("origami"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...");
                            Game.HPLoss();
                        }
                        else
                        {
                            Console.WriteLine("Commande invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "cahier":
                    if (!Game.room21)
                    {
                        if (Game.inventory.Contains("cahier"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...");
                            Game.HPLoss();
                        }
                        else
                        {
                            Console.WriteLine("Commande invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "pinceau":
                    if (!Game.room21)
                    {
                        if (Game.inventory.Contains("pinceau"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...");
                            Game.HPLoss();
                        }
                        else
                        {
                            Console.WriteLine("Commande invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "parapluie":
                    if (!Game.room21)
                    {
                        if (Game.inventory.Contains("parapluie"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...");
                            Game.HPLoss();
                        }
                        else
                        {
                            Console.WriteLine("Commande invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "craie en poudre":
                    if (!Game.room21)
                    {
                        if (Game.inventory.Contains("craie en poudre"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...");
                            Game.HPLoss();
                        }
                        else
                        {
                            Console.WriteLine("Commande invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "calculatrice":
                    if (!Game.room21)
                    {
                        if (Game.inventory.Contains("calculatrice"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...");
                            Game.HPLoss();
                        }
                        else
                        {
                            Console.WriteLine("Commande invalide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "b":
                    Console.WriteLine("Il y a une machine à coudre et un miroir sur le bureau.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 21.");
                    Game.Transition<Floor2>();
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets:");
                    Game.inventory.Sort();
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "clés":
                    Console.WriteLine("Boîte de clés:");
                    Game.box1.Sort();
                    foreach (var key in Game.box1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("- " + key);
                        Console.ResetColor();
                    }
                    Game.box2.Sort();
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

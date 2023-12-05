namespace ProjetNarratif.Rooms
{
    internal class Room22 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.room22)
            {
                return
@"La chambre est sombre puisque les [r]ideaux sont fermés.
Des affiches de groupes de musique se trouvent sur les murs et au-dessus du [b]ureau.
Claire a retrouvé son parapluie.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"La chambre est sombre puisque les [r]ideaux sont fermés.
Des affiches de groupes de musique se trouvent sur les murs et au-dessus du [b]ureau.
Claire a perdu un objet qui lui appartient: [...].
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
                case "parapluie":
                    if (Game.inventory.Contains("parapluie"))
                    {
                        Game.room22 = true;
                        Game.inventory.Remove("parapluie");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 4.");
                        Game.box2.Add("chambre 22: #4");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "brosse":
                    if (!Game.room22)
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
                    if (!Game.room22)
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
                    if (!Game.room22)
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
                    if (!Game.room22)
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
                case "béret":
                    if (!Game.room22)
                    {
                        if (Game.inventory.Contains("béret"))
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
                    if (!Game.room22)
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
                    if (!Game.room22)
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
                case "r":
                    Console.WriteLine("Tu tires les rideaux et le soleil brille particulièrement fort.");
                    break;
                case "b":
                    Console.WriteLine("Il y a de la crème solaire sur le bureau.");
                    Console.WriteLine("Il y a également une machine à thé au coin.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 22.");
                    Game.Transition<Floor2>();
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

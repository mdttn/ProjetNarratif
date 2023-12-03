namespace ProjetNarratif.Rooms
{
    internal class Room11 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.room11)
            {
                return
@"Les murs sont roses.
La chambre et le [b]ureau sont en désordre.
Cependant, le [l]it semble être la seule chose qui est propre.
Hélène a retrouvé sa brosse à cheveux.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"Les murs sont roses.
La chambre et le [b]ureau sont en désordre.
Cependant, le [l]it semble être la seule chose qui est propre.
Hélène a perdu un objet qui lui appartient: [...].
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
                case "brosse":
                    Game.room11 = true;
                    if (Game.inventory.Contains("brosse"))
                    {
                        Game.inventory.Remove("brosse");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 8.");
                        Game.box1.Add("chambre 11: #8");
                    }
                    else
                    {
                        Console.WriteLine("Elle a déjà retrouvé sa brosse à cheveux.");
                    }
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
                case "béret":
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
                    Console.WriteLine("Il y a du maquillage et un miroir au coin du bureau.");
                    break;
                case "l":
                    Console.WriteLine("Le lit est rempli de toutous et a deux gros oreillers confortables.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 11.");
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
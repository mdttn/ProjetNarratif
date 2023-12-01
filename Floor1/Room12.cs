using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room12 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.room12)
            {
                return
@"La chambre est bien rangée et propre.
Il y a des plantes situées près de la [f]enêtre et des murs.
Il y a des cahiers et des manuels sur le [b]ureau.
Annie a retrouvé son origami de fleur.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"La chambre est bien rangée et propre.
Il y a des plantes situées près de la [f]enêtre et des murs.
Il y a des cahiers et des manuels sur le [b]ureau.
Annie a perdu un objet qui lui appartient: [...].
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
                case "origami":
                    Game.room12 = true;
                    if (Game.inventory.Contains("origami"))
                    {
                        Game.inventory.Remove("origami");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 5.");
                        Game.box1.Add("chambre 12: #5");
                    }
                    else
                    {
                        Console.WriteLine("Elle a déjà retrouvé son origami de fleur.");
                    }
                    break;
                case "brosse":
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
                case "f":
                    Console.WriteLine("Il y a des pots de violettes et de fleurs de lys.");
                    Console.WriteLine("Il y a également une collection de vieux livres.");
                    break;
                case "b":
                    Console.WriteLine("Un coin du bureau semble être réservé pour des morceaux de papier jauni.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 12.");
                    Game.Transition<Floor1>();
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

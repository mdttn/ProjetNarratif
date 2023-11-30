using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room14 : Room
    {
        internal override string CreateDescription() =>
@"La chambre a les [r]ideaux ouverts et les murs sont décorés.
Il y a une collection de figurines et de livres sur des étagères.
Igor a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "pinceau":
                    if (Game.inventory.Contains("pinceau"))
                    {
                        Game.inventory.Remove("pinceau");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 6.");
                        Game.box.Add("chambre 14: #6");
                    }
                    else
                    {
                        Console.WriteLine("Il a déjà retrouvé son pinceau.");
                    }
                    break;
                case "brosse":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "origami de fleur":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "cahier":
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
                case "r":
                    Console.WriteLine("Il y a une toile incomplète du paysage que tu vois par la fenêtre.");
                    Console.WriteLine("Il y a des pots de peinture sur le bord de la fenêtre.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 14.");
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

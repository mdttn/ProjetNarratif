using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room14 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.room14)
            {
                return
@"La chambre a les [r]ideaux ouverts et les murs sont décorés.
Il y a une collection de figurines et de livres sur des étagères.
Igor a retrouvé son pinceau.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"La chambre a les [r]ideaux ouverts et les murs sont décorés.
Il y a une collection de figurines et de livres sur des étagères.
Igor a perdu un objet qui lui appartient: [...].
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
                case "pinceau":
                    if (Game.inventory.Contains("pinceau"))
                    {
                        Game.room14 = true;
                        Game.inventory.Remove("pinceau");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 6.");
                        Game.box1.Add("chambre 14: #6");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "brosse":
                    if (!Game.room14)
                    {
                        if (Game.inventory.Contains("brosse"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...\n");
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
                    if (!Game.room14)
                    {
                        if (Game.inventory.Contains("origami"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...\n");
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
                    if (!Game.room14)
                    {
                        if (Game.inventory.Contains("cahier"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...\n");
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
                    if (!Game.room14)
                    {
                        if (Game.inventory.Contains("béret"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...\n");
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
                    if (!Game.room14)
                    {
                        if (Game.inventory.Contains("parapluie"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...\n");
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
                    if (!Game.room14)
                    {
                        if (Game.inventory.Contains("craie en poudre"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...\n");
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
                    if (!Game.room14)
                    {
                        if (Game.inventory.Contains("calculatrice"))
                        {
                            Console.WriteLine("Ce n'est pas le sien...\n");
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
                    Console.WriteLine("Il y a une toile incomplète du paysage que tu vois par la fenêtre.");
                    Console.WriteLine("Il y a des pots de peinture sur le bord de la fenêtre.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 14.");
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

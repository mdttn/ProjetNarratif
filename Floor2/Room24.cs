using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room24 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.room24)
            {
                return
@"La chambre est minimaliste et bien organisée, contrairement au [b]ureau.
Des prix de concours académiques sont accrochés aux murs.
Il y a une machine à café sur la table de nuit.
Hugo a retrouvé sa calculatrice.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"La chambre est minimaliste et bien organisée, contrairement au [b]ureau.
Des prix de concours académiques sont accrochés aux murs.
Il y a une machine à café sur la table de nuit.
Hugo a perdu un objet qui lui appartient: [...].
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
                case "calculatrice":
                    if (Game.inventory.Contains("calculatrice"))
                    {
                        Game.room24 = true;
                        Game.inventory.Remove("calculatrice");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 3.");
                        Game.box2.Add("chambre 24: #3");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "brosse":
                    if (!Game.room24)
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
                    if (!Game.room24)
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
                    if (!Game.room24)
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
                case "pinceau":
                    if (!Game.room24)
                    {
                        if (Game.inventory.Contains("pinceau"))
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
                    if (!Game.room24)
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
                    if (!Game.room24)
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
                    if (!Game.room24)
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
                case "b":
                    Console.WriteLine("Le bureau est débordé de documents de travail en plus d'un cahier de chimie.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 24.");
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

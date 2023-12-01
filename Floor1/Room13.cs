using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room13 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.room13)
            {
                return
@"La chambre a des meubles à étagères remplies de livres.
Il y a un jeu de fléchettes magnétiques accroché au mur et un échiquier sur une petite table.
Il y a une lampe sur la table de nuit et sur le [b]ureau.
Alain a retrouvé son cahier.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"La chambre a des meubles à étagères remplies de livres.
Il y a un jeu de fléchettes magnétiques accroché au mur et un échiquier sur une petite table.
Il y a une lampe sur la table de nuit et sur le [b]ureau.
Alain a perdu un objet qui lui appartient: [...].
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
                case "cahier":
                    Game.room13 = true;
                    if (Game.inventory.Contains("cahier"))
                    {
                        Game.inventory.Remove("cahier");
                        Console.WriteLine("Tu l'as retrouvé!");
                        Console.WriteLine("Tu trouves une clé numérotée du chiffre 2.");
                        Game.box1.Add("chambre 13: #2");
                    }
                    else
                    {
                        Console.WriteLine("Il a déjà retrouvé son cahier.");
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
                    Console.WriteLine("Il y a un étui et un manuel sur le bureau.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 13.");
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

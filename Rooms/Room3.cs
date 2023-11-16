using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room3 : Room
    {
        internal override string CreateDescription() =>
@"La chambre a des meubles à étagères remplies de livres.
Il y a un jeu de fléchettes magnétiques accroché au mur et un échiquier sur une petite table.
Il y a des lampes sur le [b]ureau et sur la [t]able de nuit.
Alain a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cahier":
                    if (Game.inventory.Contains("cahier"))
                    {
                        Game.inventory.Remove("cahier");
                    }
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 2.");
                    Game.inventory.Add("Clé de la chambre 13: #2");
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
                case "liste":
                    Console.WriteLine("Liste d'objets perdus:");
                    Console.WriteLine("Liste d'objets perdus:");
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "c":
                    Console.WriteLine("Tu retournes dans le corridor.");
                    Game.Transition<Floor1>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

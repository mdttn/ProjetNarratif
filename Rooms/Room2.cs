using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room2 : Room
    {
        internal override string CreateDescription() =>
@"La chambre est bien rangée et propre.
Il y a des plantes situées près de la [f]enêtre et des murs.
Il y a des cahiers et des manuels sur le [b]ureau.
Annie a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "origami":
                    //Game.ObjectList[Game.ObjectCount] = Game.Found("brosse");
                    //Game.ObjectCount--;
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 5.");
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
                case "f":

                    break;
                case "b":

                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets perdus:");
                    for (int i = 0; i < Game.ObjectCount; i++)
                    {
                        Console.WriteLine("- " + Game.ObjectList[i]);
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

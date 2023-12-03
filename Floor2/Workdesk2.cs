using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Workdesk2 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.cahier)
            {
                return
@"Tu peux changer de place: [1], [3], [4], [5], [6], ou [p]artir des tables.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"Tu trouves un [cahier] d'exercices sur la table.
Tu peux changer de place: [1], [3], [4], [5], [6], ou [p]artir des tables.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Tu t'asseois à la première table.");
                    Game.Transition<Workdesk1>();
                    break;
                case "3":
                    Console.WriteLine("Tu t'asseois à la troisième table.");
                    Game.Transition<Workdesk3>();
                    break;
                case "4":
                    Console.WriteLine("Tu t'asseois à la quatrième table.");
                    Game.Transition<Workdesk4>();
                    break;
                case "5":
                    Console.WriteLine("Tu t'asseois à la cinquième table.");
                    Game.Transition<Workdesk5>();
                    break;
                case "6":
                    Console.WriteLine("Tu t'asseois à la sixième table.");
                    Game.Transition<Workdesk6>();
                    break;
                case "cahier":
                    if (!Game.cahier)
                    {
                        Game.cahier = true;
                        Game.inventory.Add("cahier");
                        Console.WriteLine("Tu as pris le cahier.");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "p":
                    Console.WriteLine("Tu te lèves de la chaise.");
                    Game.Transition<Library>();
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
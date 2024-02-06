using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal override string CreateDescription()
        {
            if (Game.brosse)
            {
                return
@"Tu es devant le [m]iroir.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"Tu es devant le [m]iroir.
Tu vois une [brosse] à cheveux à côté d'un lavabot.
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
                    if (!Game.brosse)
                    {
                        Game.brosse = true;
                        Game.inventory.Add("brosse");
                        Console.WriteLine("Tu as pris la brosse à cheveux.");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "m":
                    if (Game.parapluie)
                    {
                        Console.WriteLine("Tu te regardes dans le miroir.");
                    }
                    else
                    {
                        Console.WriteLine("En te regardant dans le miroir, tu t'aperçois qu'un [parapluie] est accroché à une porte de cabine ouverte.");
                    }
                    break;
                case "parapluie":
                    if (!Game.parapluie)
                    {
                        Game.parapluie = true;
                        Game.inventory.Add("parapluie");
                        Console.WriteLine("Tu as pris le parapluie.");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "c":
                    Console.WriteLine("Tu retournes dans le corridor.");
                    Game.Transition<Floor1>();
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets:");
                    Game.inventory.Sort();
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "clés":
                    Console.WriteLine("Boîte de clés:");
                    Game.box1.Sort();
                    foreach (var key in Game.box1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("- " + key);
                        Console.ResetColor();
                    }
                    Game.box2.Sort();
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

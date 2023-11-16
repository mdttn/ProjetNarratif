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

Tu as a une [liste] d'objets perdus que tu as ramassés.
";
            }
            else
            {
                return
@"Tu es devant le [m]iroir.
Tu vois une [brosse] à cheveux à côté d'un lavabot.
Tu peux revenir dans le [c]orridor.

Tu as a une [liste] d'objets perdus que tu as ramassés.
";
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
                        Console.WriteLine("Tu as déjà pris la brosse à cheveux.");
                    }
                    break;
                case "m":

                    break;
                case "liste":
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

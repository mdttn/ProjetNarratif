using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal bool brosse;

        internal override string CreateDescription()
        {
            if (brosse)
            {
                return
@"Tu es devant le [m]iroir.
Tu peux revenir dans le [c]orridor.
";
            }
            else
            {
                return
@"Tu es devant le [m]iroir.
Tu vois une [brosse] à cheveux à côté d'un lavabot.
Tu peux revenir dans le [c]orridor.
";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "brosse":
                    brosse = true;
                    Game.ObjectList[Game.ObjectCount] = Game.Objects("brosse");
                    Game.ObjectCount++;
                    Console.WriteLine("Tu as pris la brosse à cheveux.");
                    break;
                case "m":

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

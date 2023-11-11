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
@"Tu te regardes dans le miroir.
Tu peux revenir dans le [c]orridor.
";
            }
            else
            {
                return
@"Tu te regardes dans le miroir.
Tu vois une [brosse] à cheveux à côté d'un lavabot.
Tu peux revenir dans le [c]orridor.
";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            //var objects = new List<string>();

            switch (choice)
            {
                case "brosse":
                    brosse = true;
                    Console.WriteLine("Tu as pris la brosse à cheveux.");
                    //objects.Add("brosse");
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

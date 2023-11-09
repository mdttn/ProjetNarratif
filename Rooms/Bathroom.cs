using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal override string CreateDescription() =>
@"Tu te regardes dans le miroir.
Tu vois une [brosse] à cheveux à côté d'un lavabot.
Tu peux revenir dans le [corridor].
";

        internal override void ReceiveChoice(string choice)
        {
            //var objects = new List<string>();

            switch (choice)
            {
                case "brosse":
                    Console.WriteLine("Tu as pris la brosse à cheveux.");
                    //objects.Add("brosse");
                    break;
                case "corridor":
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

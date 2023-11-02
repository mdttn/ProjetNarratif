using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class LivingRoom : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"Dans le salon, il y a un [sofa] sur lequel tu peux t'étendre.
Tu peux regarder la [télé] devant.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "sofa":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    break;
                case "télé":
                    Console.WriteLine("Tu touches la télé et tu te fais transporter dans un autre monde.");
                    Game.Finish();
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

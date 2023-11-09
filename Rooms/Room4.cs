using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Room4 : Room
    {
        internal override string CreateDescription() =>
@"La chambre a les rideaux ouverts.
Il y a une collection de figurines et de livres sur des étagères.
Il y a des toiles de paysages naturels.
L'élève qui réside dans cette chambre a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [corridor].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "pinceau":
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 6.");
                    break;
                case "brosse":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "origami":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "cahier":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
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

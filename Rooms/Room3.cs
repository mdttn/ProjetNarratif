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
Il y a des lampes sur le bureau et sur la table de nuit.
L'élève qui réside dans cette chambre a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [corridor].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cahier":
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 2.");
                    break;
                case "corridor":
                    Console.WriteLine("Tu retournes dans le corridor.");
                    Game.Transition<Floor1>();
                    break;
                default:
                    Console.WriteLine("Ce n'est pas le sien.");
                    break;
            }
        }
    }
}

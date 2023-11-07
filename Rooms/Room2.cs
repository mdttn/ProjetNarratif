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
Il y a des plantes situées près de la fenêtre et des murs.
Il y a des cahiers et des manuels sur le bureau.
L'élève qui réside dans cette chambre a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [corridor].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "origami":
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 5.");
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

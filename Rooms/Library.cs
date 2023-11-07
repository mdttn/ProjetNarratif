using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Library : Room
    {
        internal override string CreateDescription() =>
@"Le silence règne dans la bibliothèque remplie d'étagères de livres et de manuels.
Sur le long du mur devant toi et vers la gauche, il y a des tables de travail.
À ta droite, il y a le comptoir pour emprunter des ouvrages.
Au fond de la salle, il y a des fauteuils et des bean bags.
Au sol, tu trouves un cahier d'exercices.
Tu peux revenir dans le [corridor].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "corridor":
                    Console.WriteLine("Tu sors de la bibliothèque.");
                    Game.Transition<Floor1>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

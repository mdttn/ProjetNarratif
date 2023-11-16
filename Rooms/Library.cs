using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Library : Room
    {
        internal override string CreateDescription()
        {
            if (Game.cahier)
            {
                return
@"Le silence règne dans la bibliothèque remplie d'étagères de livres et de manuels.
Sur tout le long du mur devant toi, il y a des tables de travail.
À ta droite, il y a le comptoir pour emprunter des ouvrages.
Au fond de la salle, il y a des fauteuils et des bean bags.
Tu peux revenir dans le [c]orridor.
";
            }
            else
            {
                return
@"Le silence règne dans la bibliothèque remplie d'étagères de livres et de manuels.
Sur tout le long du mur devant toi, il y a des tables de travail.
À ta droite, il y a le comptoir pour emprunter des ouvrages.
Au fond de la salle, il y a des fauteuils et des bean bags.
Au sol, tu trouves un [cahier] d'exercices.
Tu peux revenir dans le [c]orridor.
";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cahier":
                    if (!Game.cahier)
                    {
                        Game.cahier = true;
                        Game.inventory.Add("cahier");
                        Console.WriteLine("Tu as ramassé le cahier.");
                    }
                    else
                    {
                        Console.WriteLine("Tu as déjà ramassé le cahier.");
                    }
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets perdus:");
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "c":
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

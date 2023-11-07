using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Floor2 : Room
    {
        internal override string CreateDescription() =>
@"Tu es au deuxième étage.
Devant toi, il y a 4 chambres.
À ta droite, il y a un [escalier] menant au 1er étage.
À ta gauche, il y a une toilette.
Au sol, tu trouves un origami de fleur fait en papier déchiré d'un livre.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "escalier":
                    Console.WriteLine("Tu descends des marches.");
                    Game.Transition<Floor1>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Floor2 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.origami)
            {
                return
@"Tu es au deuxième étage.
Devant toi, il y a 4 chambres.
À ta droite, il y a un [e]scalier menant au 1er étage.
À ta gauche, il y a une toilette.

Tu as a une [liste] d'objets perdus que tu as ramassés.
";
            }
            else
            {
                return
@"Tu es au deuxième étage.
Devant toi, il y a 4 chambres.
À ta droite, il y a un [e]scalier menant au 1er étage.
À ta gauche, il y a une toilette.
Au sol, tu trouves un [origami] de fleur fait en papier déchiré d'un livre.

Tu as a une [liste] d'objets perdus que tu as ramassés.
";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "origami":
                    Game.origami = true;
                    Game.ObjectList[Game.ObjectCount] = Game.Origami(true);
                    Game.ObjectCount++;
                    Console.WriteLine("Tu as ramassé l'origami.");
                    break;
                case "pinceau":
                    Game.pinceau = true;
                    Game.ObjectList[Game.ObjectCount] = Game.Pinceau(true);
                    Game.ObjectCount++;
                    Console.WriteLine("Tu as ramassé le pinceau.");
                    break;
                case "e":
                    Console.WriteLine("Tu descends des marches.");
                    Game.Transition<Floor1>();
                    break;
                //case "t":

                //    break;
                case "liste":
                    Console.WriteLine("Liste d'objets perdus:");
                    for (int i = 0; i < Game.ObjectCount; i++)
                    {
                        Console.WriteLine("- " + Game.ObjectList[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

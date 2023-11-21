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

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
";
            }
            else
            {
                return
@"Tu es au deuxième étage.
Devant toi, il y a 4 chambres.
À ta droite, il y a un [e]scalier menant au 1er étage.
À ta gauche, il y a une [t]oilette.
Au sol, tu trouves un [origami] de fleur fait en papier déchiré d'un livre.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "origami":
                    if (!Game.origami)
                    {
                        Game.origami = true;
                        Game.inventory.Add("origami");
                        Console.WriteLine("Tu as ramassé l'origami.");
                    }
                    else
                    {
                        Console.WriteLine("Tu as déjà ramassé l'origami.");
                    }
                    break;
                case "pinceau":
                    if (!Game.pinceau)
                    {
                        Game.pinceau = true;
                        Game.inventory.Add("pinceau");
                        Console.WriteLine("Tu as ramassé le pinceau.");
                    }
                    else
                    {
                        Console.WriteLine("Tu as déjà ramassé le pinceau.");
                    }
                    break;
                case "e":
                    Console.WriteLine("Tu descends des marches.");
                    Game.Transition<Floor1>();
                    break;
                case "t":

                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets perdus:");
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "clés":
                    Console.WriteLine("Boîte de clés:");
                    foreach (var key in Game.box)
                    {
                        Console.WriteLine("- " + key);
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

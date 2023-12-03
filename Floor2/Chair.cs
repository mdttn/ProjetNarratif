using ProjetNarratif.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Floor2
{
    internal class Chair : Room
    {
        internal override string CreateDescription()
        {
            if (Game.origami)
            {
                return
@"Tu t'asseois sur un des fauteuils.
Tu peux te [l]ever du fauteuil.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"Tu t'asseois sur un des fauteuils.
Tu vois un [origami] de fleur fait en vieux papier jauni déchiré au sol.
Tu peux te [l]ever du fauteuil.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
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
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "l":
                    Console.WriteLine("Tu retournes à l'entrée de la bibliothèque.");
                    Game.Transition<Library>();
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets:");
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "clés":
                    Console.WriteLine("Boîte de clés:");
                    foreach (var key in Game.box1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("- " + key);
                        Console.ResetColor();
                    }
                    foreach (var key in Game.box2)
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

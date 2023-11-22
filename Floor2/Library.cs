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
@"Le silence règne dans la bibliothèque.
Sur le long du mur devant toi, il y a des [t]ables pour travailler.
À ta droite, il y a le comptoi[r] où tu peux emprunter des ouvrages.
Au fond de la salle, il y a des [f]auteuils et des [b]ean bags.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "t":
                    Console.WriteLine("Tu vas vers les espaces de travail.");
                    Game.Transition<Workdesks>();
                    break;
                case "r":
                    Console.WriteLine("Tu te rends au comptoir d'emprunt.");
                    Game.Transition<Counter>();
                    break;
                case "f":
                    Console.WriteLine("Tu vas au fond de la bibliothèque.");
                    //Game.Transition<Chair>();
                    break;
                case "b":
                    if (!Game.nap)
                    {
                        Game.nap = true;
                        Game.HP++;
                        Console.WriteLine("Tu vas au fond de la bibliothèque et tu t'endors sur le bean bag.\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tu as récupéré 1 pt de vie.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Tu vas au fond de la bibliothèque et tu te reposes sur le bean bag pendant un moment.");
                    }
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la bibliothèque.");
                    Game.Transition<Floor1>();
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
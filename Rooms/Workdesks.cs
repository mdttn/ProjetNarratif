﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Workdesks : Room
    {
        internal override string CreateDescription() =>
@"Il y a 6 tables disponibles, placées l'une en face de l'autre en ilots de 2: [1], [2], [3], [4], [5], [6].
Tu peux revenir à l'entrée de la [b]ibliothèque.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Tu t'asseois à la première table.");
                    Game.Transition<Workdesk1>();
                    break;
                case "2":
                    Console.WriteLine("Tu t'asseois à la deuxième table.");
                    Game.Transition<Workdesk2>();
                    break;
                case "3":
                    Console.WriteLine("Tu t'asseois à la troisième table.");
                    //Game.Transition<Workdesk1>();
                    break;
                case "4":
                    Console.WriteLine("Tu t'asseois à la quatrième table.");
                    //Game.Transition<Workdesk1>();
                    break;
                case "5":
                    Console.WriteLine("Tu t'asseois à la cinquième table.");
                    Game.Transition<Workdesk5>();
                    break;
                case "6":
                    Console.WriteLine("Tu t'asseois à la sixième table.");
                    Game.Transition<Workdesk6>();
                    break;
                case "b":
                    Game.Transition<Library>();
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
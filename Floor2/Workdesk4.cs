﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Workdesk4 : Room
    {
        internal override string CreateDescription() =>
@"Tu peux changer de place: [1], [2], [3], [5], [6], ou [p]artir des tables.

Tu as une [liste] d'objets que tu as ramassés.
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
                    Game.Transition<Workdesk3>();
                    break;
                case "5":
                    Console.WriteLine("Tu t'asseois à la cinquième table.");
                    Game.Transition<Workdesk5>();
                    break;
                case "6":
                    Console.WriteLine("Tu t'asseois à la sixième table.");
                    Game.Transition<Workdesk6>();
                    break;
                case "p":
                    Console.WriteLine("Tu te lèves de la chaise.");
                    Game.Transition<Library>();
                    break;
                case "liste":
                    Console.WriteLine("Liste d'objets:");
                    Game.inventory.Sort();
                    foreach (var item in Game.inventory)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                case "clés":
                    Console.WriteLine("Boîte de clés:");
                    Game.box1.Sort();
                    foreach (var key in Game.box1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("- " + key);
                        Console.ResetColor();
                    }
                    Game.box2.Sort();
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
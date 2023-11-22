﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Workdesk6 : Room
    {
        internal override string CreateDescription()
        {
            if (Game.livre)
            {
                return
@"Tu peux changer de place: [1], [2], [3], [4], [5], ou [p]artir des tables.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"Tu trouves un [livre] qui t'intrigue sur la table.
Tu peux changer de place: [1], [2], [3], [4], [5], ou [p]artir des tables.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
        }

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
                case "4":
                    Console.WriteLine("Tu t'asseois à la quatrième table.");
                    Game.Transition<Workdesk4>();
                    break;
                case "5":
                    Console.WriteLine("Tu t'asseois à la cinquième table.");
                    Game.Transition<Workdesk5>();
                    break;
                case "livre":
                    if (!Game.livre)
                    {
                        Game.livre = true;
                        Game.inventory.Add("livre (à emprunter)");
                        Console.WriteLine("Tu feuillettes le livre et tu décides de l'emprunter.");
                    }
                    else
                    {
                        Console.WriteLine("Tu as déjà pris le livre.");
                    }
                    break;
                case "p":
                    Console.WriteLine("Tu te lèves de la chaise.");
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

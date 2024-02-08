using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Counter : Room
    {
        internal override string CreateDescription() =>
@"Scanne le type d'ouvrage que tu veux emprunter: [...].
Tu peux [r]evenir.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "livre":
                    if (Game.inventory.Contains("livre (à emprunter)"))
                    {
                        Game.inventory.Remove("livre (à emprunter)");
                    }
                    if (Game.calc)
                    {
                        Console.WriteLine("Tu as réussi à emprunter le livre.");
                    }
                    else
                    {
                        Console.WriteLine("Tu as réussi à emprunter le livre.");
                        Console.WriteLine("Tu trouves une [calculatrice] au coin du comptoir.");
                    }
                    break;
                case "calculatrice":
                    if (!Game.calc)
                    {
                        Game.calc = true;
                        Game.inventory.Add("calculatrice");
                        Console.WriteLine("Tu as pris la calculatrice.");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "cahier":
                    Console.WriteLine("Le cahier n'appartient pas à la bibliothèque.");
                    break;
                case "r":
                    Console.WriteLine("Tu libères le comptoir.");
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

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
@"Scanne le type d'ouvrage que tu veux emprunter: [...]
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
                        Console.WriteLine("Tu as déjà pris la calculatrice.");
                    }
                    break;
                case "cahier":
                    Console.WriteLine("Le cahier n'appartient pas à la bibliothèque.");
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

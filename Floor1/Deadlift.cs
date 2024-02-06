using ProjetNarratif.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Floor1
{
    internal class Deadlift : Room
    {
        static int weight;

        internal override string CreateDescription()
        {
            if (Game.chalk)
            {
                return
@"Sur le côté, il y a des plaques pour ajouter du poids à la barre.
Tu t'apprêtes à faire un [s]oulevé de terre.
Tu peux [r]evenir et aller vers d'autres machines.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
            else
            {
                return
@"Sur le côté, il y a des plaques pour ajouter du poids à la barre.
Tu remarques alors qu'il y a de la [craie en poudre] à côté de la barre.
Tu t'apprêtes à faire un [s]oulevé de terre.
Tu peux [r]evenir et aller vers d'autres machines.

Tu as une [liste] d'objets que tu as ramassés.
Tu as une boîte de [clés].
---";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "s":
                label1:
                    Console.Write("Tu rajoutes des poids (lbs): ");
                    try
                    {
                        weight = Convert.ToInt32(Console.ReadLine());
                        if (weight <= 0 || weight > 450)
                        {
                            goto label1;
                        }
                    }
                    catch (Exception)
                    {
                        goto label1;
                    }
                    if (!Game.weight)
                    {
                        Game.weight = true;
                        Game.HP++;
                        Console.WriteLine($"Tu prends la barre et tu soulèves {weight + 45} lbs.");
                        Console.WriteLine("Tu laisses tomber la barre après quelques secondes.\n"); 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tu as récupéré 1 pt de vie.");
                        Console.ResetColor();
                        Console.WriteLine($"Tu as {Game.HP} pts d'énergie.");
                    }
                    else
                    {
                        Console.WriteLine($"Tu prends la barre et tu soulèves {weight + 45} lbs.");
                        Console.WriteLine("Tu laisses tomber la barre après quelques secondes.");
                    }
                    break;
                case "craie en poudre":
                    if (!Game.chalk)
                    {
                        Game.chalk = true;
                        Game.inventory.Add("craie en poudre");
                        Console.WriteLine("Tu as pris la craie en poudre.");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;
                case "r":
                    Console.WriteLine("Tu t'en vas voir d'autres machines.");
                    Game.Transition<Gym>();
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

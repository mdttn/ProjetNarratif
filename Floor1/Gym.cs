using ProjetNarratif.Floor1;

namespace ProjetNarratif.Rooms
{
    internal class Gym : Room
    {
        static int weight;

        internal override string CreateDescription() =>
@"Devant toi, il y a des machines pour entraîner les jambes.
À ta gauche, il y a un pèse-personne.
À ta droite, il y a des machines pour les bras, des [h]altères, des bancs et des tapis.
Au fond de la salle, il y a des barres et un espace pour faire un [s]oulevé de terre.
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "h":
                label1:
                    Console.Write("Tu te prends des poids en lbs: ");
                    try
                    {
                        weight = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        goto label1;
                    }
                    if (!Game.weight)
                    {
                        Game.weight = true;
                        Game.HP++;
                        Console.WriteLine($"Tu fais quelques séries avec les haltères de {weight} lbs et tu reviens.\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tu as récupéré 1 pt de vie.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"Tu fais quelques séries avec les haltères de {weight} lbs et tu reviens.");
                    }
                    break;
                case "s":
                    Console.WriteLine("Tu vas vers la barre de soulevé de terre.");
                    Game.Transition<Deadlift>();
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la salle d'entraînement.");
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

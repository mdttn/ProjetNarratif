namespace ProjetNarratif.Rooms
{
    internal class Room22 : Room
    {
        internal override string CreateDescription() =>
@"La chambre est sombre parce que les rideaux sont fermés.
Les murs sont partiellement couverts de dessins de nuages et de pluie.
Il y a des affiches de groupes de musique sur les murs et au-dessus du [b]ureau.
Claire a perdu un objet qui lui appartient: [...].
Tu peux revenir dans le [c]orridor.

Tu as une [liste] d'objets perdus que tu as ramassés.
Tu as une boîte de [clés].
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "parapluie":
                    if (Game.inventory.Contains("parapluie"))
                    {
                        Game.inventory.Remove("parapluie");
                    }
                    Console.WriteLine("Tu l'as retrouvé!");
                    Console.WriteLine("Tu trouves une clé numérotée du chiffre 4.");
                    Game.box.Add("chambre 22: clé #4");
                    break;
                case "brosse":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "origami":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "cahier":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "pinceau":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "béret":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "craie en poudre":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "calculatrice":
                    Console.WriteLine("Ce n'est pas le sien...\n");
                    Game.HPLoss();
                    break;
                case "b":
                    Console.WriteLine("Il y a de la crème solaire et d'autres produits pour la peau sensible sur le bureau.");
                    Console.WriteLine("Il y a également une machine à thé au coin.");
                    break;
                case "c":
                    Console.WriteLine("Tu sors de la chambre 22.");
                    Game.Transition<Floor2>();
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

namespace ProjetNarratif.Rooms
{
    internal class Floor1 : Room
    {
        internal override string CreateDescription() =>
@"Tu es au premier étage.
Devant toi, il y a les chambres [1], [2], [3] et [4].
À ta droite, il y a un [escalier] menant au 2e étage.
À ta gauche, il y a la [bibliothèque] et une [toilette].
Derrière toi, il y a une [porte] menant vers l'extérieur.
";
//Tu as une liste d'objets perdus.

        internal override void  ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Tu entres dans la première chambre.");
                    Game.Transition<Room1>();
                    break;
                case "2":
                    Console.WriteLine("Tu entres dans la deuxième chambre.");
                    Game.Transition<Room2>();
                    break;
                case "3":
                    Console.WriteLine("Tu entres dans la troisième chambre");
                    Game.Transition<Room3>();
                    break;
                case "4":
                    Console.WriteLine("Tu entres dans la quatrième chambre");
                    Game.Transition<Room4>();
                    break;
                case "escalier":
                    Console.WriteLine("Tu montes des marches et tu vois un pinceau.");
                    Game.Transition<Floor2>();
                    break;
                case "bibliothèque":
                    Console.WriteLine("Tu rentres dans la biliothèque.");
                    Game.Transition<Library>();
                    break;
                case "toilette":
                    Console.WriteLine("Tu entres dans la toilette.");
                    Game.Transition<Bathroom>();
                    break;
                case "porte":
                    Console.WriteLine("Tu te tournes vers la porte.");
                    Game.Transition<Exit>();
                    break;
                //case "liste":
                //    Console.WriteLine("Liste d'objets perdus:\n");
                //    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

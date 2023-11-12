using ProjetNarratif.Rooms;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameFinished() => isFinished;
        internal bool IsGameOver() => isOver;
        static bool isFinished;
        static bool isOver;
        static string nextRoom = "";
        internal static int HP = 3;
        internal static bool pinceau;
        internal static string[] ObjectList = new string[10];
        internal static int ObjectCount;

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal static void HPLoss()
        {
            HP--;
            if (HP > 1)
            {
                Console.WriteLine($"Il te reste *{HP}* pts d'énergie.");
            }
            else if (HP == 1)
            {
                Console.WriteLine($"Il te reste *{HP}* pt d'énergie.");
            }
            else
            {
                Console.WriteLine("Tu es trop fatigué.e. pour continuer à chercher des objets perdus.");
                GameOver();
            }
        }

        internal static string Objects(string obj)
        {
            if (obj == "brosse")
            {
                obj = ("brosse").ToString();
            }
            if (obj == "origami")
            {
                obj = ("origami").ToString();
            }
            if (obj == "cahier")
            {
                obj = ("cahier").ToString();
            }
            if (obj == "pinceau")
            {
                obj = ("pinceau").ToString();
            }
            return obj;
        }

        //internal static string Found(string found)
        //{
        //    if (found == "brosse")
        //    {
        //        found = ("").ToString();
        //    }
        //    if (found == "origami")
        //    {
        //        found = ("").ToString();
        //    }
        //    if (found == "cahier")
        //    {
        //        found = ("").ToString();
        //    }
        //    if (found == "pinceau")
        //    {
        //        found = ("").ToString();
        //    }
        //    return found;
        //}

        internal static void Pinceau()
        {
            if (pinceau)
            {
                ObjectList[ObjectCount] = Objects("pinceau");
                ObjectCount++;
                Console.WriteLine("Tu montes des marches.");
            }
            else
            {
                Console.WriteLine("Tu montes des marches et tu trouves un [pinceau].");
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentRoom.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        internal static void GameOver()
        {
            isOver = true;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    Console.WriteLine("---");
                    break;
                }
            }
        }
    }
}

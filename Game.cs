using ProjetNarratif.Rooms;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";
        internal static int HP = 3;
        internal static bool pinceau;

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
                Finish();
            }
        }

        internal static void Pinceau()
        {
            if (pinceau)
            {
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
                    break;
                }
            }
        }
    }
}

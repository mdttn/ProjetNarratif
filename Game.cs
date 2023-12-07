using ProjetNarratif.Rooms;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameFinished() => isFinished;
        internal bool IsGameOver() => isOver;
        internal bool HasQuit() => hasQuit;
        static bool isFinished;
        static bool isOver;
        static bool hasQuit;
        static string nextRoom = "";
        internal static int HP = 1;
        internal static bool brosse, origami, cahier, pinceau, béret, parapluie, chalk, calc;
        internal static bool livre, nap, weight, gympass;
        internal static bool room11, room12, room13, room14, room21, room22, room23, room24;
        internal static List<string> inventory = new List<string>();
        internal static List<string> box1 = new List<string>();
        internal static List<string> box2 = new List<string>();
        internal static Stopwatch timer = new Stopwatch();
        internal static bool start, firststop;
        internal static int essai = 3;
        internal static bool solved;

        internal static void Riddle()
        {
            essai--;
            if (essai == 2)
            {
                Console.WriteLine("Je te donne un indice:\nC'est un élève situé au premier étage. (1-4)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nIl te reste {essai} essais.");
                Console.ResetColor();
            }
            else if (essai == 1)
            {
                Console.WriteLine("Je te donne un indice:\nC'est un garçon.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nIl te reste {essai} essai.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Tant pis...");
                Console.WriteLine("\nTu es trop fatigué.e pour continuer à chercher des objets perdus.");
                GameOver();
            }
        }

        internal static void HPLoss()
        {
            HP--;
            if (HP > 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nIl te reste {HP} pts d'énergie.");
                Console.ResetColor();
            }
            else if (HP == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nIl te reste {HP} pt d'énergie.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nTu es trop fatigué.e pour continuer à chercher des objets perdus.");
                GameOver();
            }
        }

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
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

        internal static void Quit()
        {
            hasQuit = true;
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

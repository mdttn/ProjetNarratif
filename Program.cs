using ProjetNarratif;
using ProjetNarratif.Floor1;
using ProjetNarratif.Floor2;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Start());
game.Add(new Floor1());
game.Add(new Room11());
game.Add(new Room12());
game.Add(new Room13());
game.Add(new Room14());
game.Add(new Bathroom());
game.Add(new Gym());
game.Add(new Deadlift());
game.Add(new Exit());
game.Add(new Floor2());
game.Add(new Room21());
game.Add(new Room22());
game.Add(new Room23());
game.Add(new Room24());
game.Add(new Library());
game.Add(new Workdesks());
game.Add(new Workdesk1());
game.Add(new Workdesk2());
game.Add(new Workdesk3());
game.Add(new Workdesk4());
game.Add(new Workdesk5());
game.Add(new Workdesk6());
game.Add(new Chair());
game.Add(new Counter());

while (!game.IsGameFinished() && !game.IsGameOver() && !game.HasQuit())
{
    if (Game.start)
    {
        Game.timer.Start();
    }
    if (Game.timer.Elapsed.Minutes < 20)
    {
        Console.WriteLine("---");
        Console.WriteLine("Temps écoulé: " + Game.timer.Elapsed.Minutes + " min");
        Console.WriteLine("---");
        Console.WriteLine(game.CurrentRoomDescription);
        string? choice = Console.ReadLine()?.ToLower() ?? "";
        Console.Clear();
        game.ReceiveChoice(choice);
    }
    else if (Game.timer.Elapsed.Minutes >= 20)
    {
        if (!Game.firststop)
        {
            Game.firststop = true;
            Game.HPLoss();
            if (Game.HP >= 1)
            {
                Console.WriteLine("---");
                Console.WriteLine("Temps écoulé: " + Game.timer.Elapsed.Minutes + " min");
                Console.WriteLine("---");
                Console.WriteLine(game.CurrentRoomDescription);
                string? choice = Console.ReadLine()?.ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }
        }
        else
        {
            if (Game.timer.Elapsed.Minutes >= 25)
            {
                Game.GameOver();
            }
        }
    }
}

if (game.IsGameFinished())
{
    Console.WriteLine("---");
    Console.WriteLine("Temps écoulé: " + Game.timer.Elapsed.Minutes + " min");
    Console.WriteLine("---");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("THE END");
    Console.ResetColor();
}

else if (game.IsGameOver())
{
    Console.WriteLine("---");
    Console.WriteLine("Temps écoulé: " + Game.timer.Elapsed.Minutes + " min");
    Console.WriteLine("---");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("GAME OVER");
    Console.ResetColor();
}

else if (game.HasQuit())
{
    Console.WriteLine("---");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("EXIT");
    Console.ResetColor();
}

Console.ReadKey();
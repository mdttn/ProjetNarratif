﻿using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Floor1());
game.Add(new Room1());
game.Add(new Room2());
game.Add(new Room3());
game.Add(new Room4());
game.Add(new Library());
game.Add(new Bathroom());
game.Add(new Floor2());
game.Add(new Exit());

while (!game.IsGameFinished() && !game.IsGameOver())
{
    Console.WriteLine("---");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

if (game.IsGameFinished())
{
    Console.WriteLine("\nTHE END");
}

else if (game.IsGameOver())
{
    Console.WriteLine("\nGAME OVER");
}

Console.ReadKey();
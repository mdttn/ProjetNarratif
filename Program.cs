using ProjetNarratif;
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
game.Add(new Bathroom());

while (!game.IsGameOver())
{
    Console.WriteLine("---");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadKey();
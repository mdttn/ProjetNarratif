using ProjetNarratif.Floor1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Riddle : Room
    {
        internal override string CreateDescription() =>
@"À qui appartient le cahier?

[1] Hélène
[2] Annie
[3] Alain
[4] Igor
[5] Diana
[6] Claire
[7] Ben
[8] Hugo
---";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Game.Riddle();
                    break;
                case "2":
                    Game.Riddle();
                    break;
                case "3":
                    Console.WriteLine("Oui, c'est à lui!");
                    Game.solved = true;
                    Game.Transition<Floor1>();
                    break;
                case "4":
                    Game.Riddle();
                    break;
                case "5":
                    Game.Riddle();
                    break;
                case "6":
                    Game.Riddle();
                    break;
                case "7":
                    Game.Riddle();
                    break;
                case "8":
                    Game.Riddle();
                    break;
                default:
                    // reset
                    break;

            }
        }
    }
}

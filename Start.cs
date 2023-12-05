using ProjetNarratif.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Start : Room
    {
        internal override string CreateDescription()
        {
            Console.Clear();
            return
@"
███████ ███████  ██████  █████  ██████  ███████     ██████   ██████  ██████  ███    ███     zZZ
██      ██      ██      ██zzz██ ██zzz██ ██          ██   ██ ██    ██ ██zzz██ ████  ████   zZZ
█████   ███████ ██      ███████ ██████  █████       ██   ██ ██    ██ ██████  ██ ████ ██ zZZ
██           ██ ██      ██   ██ ██      ██          ██   ██ ██    ██ ██   ██ ██  ██  ██ 
███████ ███████  ██████ ██   ██ ██      ███████     ██████   ██████  ██   ██ ██      ██ 

> TEMPS LIMITE: 20-25 min <

[1] Commencer
[2] Quitter
---";
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Game.start = true;
                    Game.Transition<Floor1>();
                    break;
                case "2":
                    Console.WriteLine("Clique 2 fois pour quitter.");
                    Game.Quit();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}

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
            string title, menu;
            Console.Clear();
            title =
@"
███████ ███████  ██████  █████  ██████  ███████     ██████   ██████  ██████  ███    ███     zZZ
██      ██      ██      ██zzz██ ██zzz██ ██          ██   ██ ██    ██ ██zzz██ ████  ████   zZZ
█████   ███████ ██      ███████ ██████  █████       ██   ██ ██    ██ ██████  ██ ████ ██ zZZ
██           ██ ██      ██   ██ ██      ██          ██   ██ ██    ██ ██   ██ ██  ██  ██ 
███████ ███████  ██████ ██   ██ ██      ███████     ██████   ██████  ██   ██ ██      ██ 
";

            menu =
@"
*TEMPS LIMITE: 20 min*

[1] Commencer
[2] Quitter
---";
            return title + menu;
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Game.Transition<Floor1>();
                    break;
                case "2":
                    Game.Quit();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}

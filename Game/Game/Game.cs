using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    // Game derived from GameInterface and must implement the functions
    class Game : GameInterface
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int ReleaseYear { get; set; }
        public bool InstallStatus { get; set; }

        public Game(string Name, string Publisher, int ReleaseYear, bool InstallStatus)
        {
            this.Name = Name;
            this.Publisher = Publisher;
            this.ReleaseYear = ReleaseYear;
            this.InstallStatus = InstallStatus;
        }

        public void InstallGame(bool isInstalled)
        {
            if (isInstalled)
            {
                Console.WriteLine("{0} is already installed! You can play it now!", Name);
            }
            else
            {
                isInstalled = true;
                Console.WriteLine("{0} is installed and ready to play!", Name);
            }

        }

        public virtual void RunGame(bool isInstalled)
        {
            if (isInstalled)
            {
                Console.WriteLine("{0} is running. Enjoy!", Name);
            }
            else
            {
                Console.WriteLine("You can't play {0} right now because it isn't installed. Please install to play!"
                    , Name);
            }
        }
    }
}

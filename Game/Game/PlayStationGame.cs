using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class PlayStationGame : ConsoleGame
    {
        public PlayStationGame(string Name, string Publisher, int ReleaseYear, bool InstallStatus, string Platform) : base(Name, Publisher, ReleaseYear, InstallStatus, Platform)
        {
            this.Name = Name;
            this.Publisher = Publisher;
            this.ReleaseYear = ReleaseYear;
            this.InstallStatus = InstallStatus;
            this.Platform = Platform;
        }
    }
}

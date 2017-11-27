using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ConsoleGame : Game
    {
        public string Platform { get; set; }

        public ConsoleGame(string Name, string Publisher, int ReleaseYear, bool InstallStatus, string Platform) : base(Name, Publisher, ReleaseYear, InstallStatus)
        {
            this.Name = Name;
            this.Publisher = Publisher;
            this.ReleaseYear = ReleaseYear;
            this.InstallStatus = InstallStatus;
            this.Platform = Platform;
        }

        public override void RunGame(bool isInstalled)
        {
            Console.WriteLine("Your {0} is on!", Platform);
            base.RunGame(isInstalled);
        }
    }
}

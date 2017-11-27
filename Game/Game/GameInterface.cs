using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface GameInterface
    {
        void InstallGame(bool isInstalled);
        void RunGame(bool isInstalled);
    }
}

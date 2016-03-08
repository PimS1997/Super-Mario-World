using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarioWorld
{
    class Level
    {

        BuildLevel bl = new BuildLevel();
        GameObject[,] level = bl.Build("level.img");

    }
}

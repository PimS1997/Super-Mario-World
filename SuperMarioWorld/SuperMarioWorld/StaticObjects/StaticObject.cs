using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarioWorld
{
    abstract class StaticObject : GameObject
    {

        bool isBreakable;
        bool isSolid;

        public StaticObject() : base()
        {

        }

    }
}

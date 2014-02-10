using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaMinerAI.Client
{
    abstract class BaseAI
    {
        public BaseAI() { }

        abstract public void Init();
        abstract public bool Run();
        abstract public void End();
    }
}

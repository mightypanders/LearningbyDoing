using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControls
{
    class Identifier
    {
        protected int globalID = 0;

        public int getuID()
        {
            globalID++;
            return globalID;
        }
    }
}

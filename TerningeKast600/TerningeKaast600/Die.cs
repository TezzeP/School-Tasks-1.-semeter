using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningeKaast600
{
    class Die
    {
        
        Random r = new Random();

        public int Roll()
        {
            return r.Next(1, 7);
        }
    }
}

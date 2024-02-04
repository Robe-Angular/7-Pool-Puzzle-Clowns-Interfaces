using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Pool_Puzzle_Clowns_Interfaces
{
    class Acts:Picasso
    {
        public Acts(): base("Acts") { }
        public override int Ear()
        {
            return 5;
        }
    }
}

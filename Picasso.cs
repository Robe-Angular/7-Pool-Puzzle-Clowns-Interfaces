using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Pool_Puzzle_Clowns_Interfaces
{
    class Picasso : Nose
    {
        public virtual int Ear()
        {
            return 7;
        }
        public Picasso(string face)
        {
            this.face = face;
        }
        public virtual string Face
        {
            get { return this.face; }
        }

        string face;
    }
    
}

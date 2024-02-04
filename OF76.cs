using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Pool_Puzzle_Clowns_Interfaces
{
    class OF76:Clowns
    {
        public override string Face
        {
            get { return "0f76"; }
        }
        public static void Main(string[] args)
        {
            string result = "";
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
            i[2] = new OF76();

            for (int x = 0; x < 3; x++){
                result += $"{i[x].Ear()} {i[x].Face} \n";
            }
            MessageBox.Show(result);
        }
    }
}

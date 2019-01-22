using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chivary.Entity
{
    class Dice
    {
        private List<int> Face = new List<int>();
        public Dice(int Min_num=1,int Max_num=6)
        {
            for (int i = Min_num; i <= Max_num; i++)
            {
                Face.Add(i);
            }
        }
        public void DisplayFace()
        {
            for (int i = 0; i < Face.Count; i++)
            {
                System.Console.WriteLine(Face[i]);
            }
        }
    }
}

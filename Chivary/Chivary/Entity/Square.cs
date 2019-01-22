using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chivary.Entity
{

    class Square
    {

        private string TypeOfSquare;
        private bool IsOccupied;
        public Square()
        {
            IsOccupied = false;
            TypeOfSquare = "   "; //0 for Land //1 for Water //2 for Jungle
        }
        public string DisplaySquare()
        {
            return TypeOfSquare;
        }
        public void SetSquare(string typeSquare,bool IsOccupied)
        {
            TypeOfSquare = typeSquare;
        }
    }
}

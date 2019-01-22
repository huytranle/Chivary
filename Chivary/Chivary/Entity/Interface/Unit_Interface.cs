using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chivary.Entity.Interface
{
    interface Unit_Interface
    {
        void MoveHorizonally();
        void MoveVertially();
        void MoveDiagonally();
        void MoveToPosition(int x, int y);
        void DoSuicide();
        void DoFlip();
        void ActiveSkill();
        void DoAttack();

        void PlaceOn();


    }
}

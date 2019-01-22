using Chivary.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chivary
{
    abstract class Unit : Unit_Interface
    {
        public abstract void MoveToPosition(int x, int y);
        public abstract void MoveHorizonally();

        public abstract void MoveVertially();



        public abstract void MoveDiagonally();


        public abstract void DoSuicide();



        public abstract void DoFlip();



        public abstract void ActiveSkill();



        public abstract void DoAttack();



        public abstract void PlaceOn();
    
    }
}

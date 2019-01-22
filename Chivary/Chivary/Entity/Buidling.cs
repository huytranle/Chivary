using Chivary.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chivary.Entity
{
    abstract class Buidling:Building_Interface
    {
        protected int HitPoint;
        public Buidling()
        {

        }
        public Buidling(int hp)
        {
            this.HitPoint = hp;
        }

        public abstract void CreateUnit();

        public abstract void DoAttack();

        public abstract void DoSuicide();
     

        public void SetHitPoint(int hp)
        {
            this.HitPoint = hp;
        }
        public int GetHitPoint()
        {
            return HitPoint;
        }
    }
}

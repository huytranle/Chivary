using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chivary.Entity.Building
{
    class Centre:Buidling
    {
        public Centre():base()
        {
        
        }
        
        public override void CreateUnit()
        {
            
        }

        public override void DoAttack()
        {
            
        }

        public override void DoSuicide()
        {
            
        }
        public void DisplayHitPoint()
        {
            System.Console.WriteLine(this.HitPoint);
        }
    }
}

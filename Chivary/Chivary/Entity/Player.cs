using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chivary.Entity
{
    class Player
    {
        private string Id;
        private string Name;
        private int Win;
        private int Lose;
        private int Gold;
        private int Diamond;
        private bool Turn;
        private string Side;
        
        public Player(string Id,string Name,bool Turn,string Side)
        {
            this.Id = Id;
            this.Name = Name;
            this.Turn = Turn;
            this.Side = Side;
        }
        public string GetSide()
        {
            return Side;
        }
        public void SetSide(string side)
        {
            this.Side = side;
        }
        public void SetTurn(bool turn)
        {
            this.Turn = turn;
        }
        public bool GetTurn()
        {
            return Turn;
        }
            
    }
}

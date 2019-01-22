using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chivary.Entity
{
    class Board
    {
        private Square[,] board;
        public Board(int rowNum,int colNum)
        {
            board= new Square[colNum, rowNum];
            for (int i = 0; i < colNum; i++)
            {
                for (int j = 0; j < rowNum; j++)
                {
                    board[i, j] = new Square();
                }
            }
        }
        public void DisplayBoard(int rowNum,int colNum)
        {
            for (int i = 0; i < colNum; i++)
            {
                if(i==0)
                {
                    Console.Write("  ");
                    for (int k=0;k< rowNum;k++)
                    {
                        if(k>=9)
                        {
                            Console.Write(" " +(k+1) + " ");
                        }
                        else
                        Console.Write("  "+(k+1)+" ");
                    }
                    Console.WriteLine("");
                }
                System.Console.WriteLine("  -----------------------------------------------------------------");
                
                    System.Console.Write(i+1+" ");
                

                for (int j = 0; j < rowNum; j++)
                {
                    
                    System.Console.Write("|" + board[i, j].DisplaySquare()+"");
                    if (j == rowNum-1)
                    {
                        System.Console.WriteLine("| "+(i+1));
                    }
                    
                }
                if(i==colNum-1)
                {
                    //System.Console.WriteLine("---------------------------------");
                    System.Console.WriteLine("  -----------------------------------------------------------------");
                    
                        Console.Write("  ");
                        for (int k = 0; k < rowNum; k++)
                        {
                            if (k >= 9)
                            {
                                Console.Write(" " + (k + 1) + " ");
                            }
                            else
                                Console.Write("  " + (k+1) + " ");
                        }
                        Console.WriteLine("");
                    
                }
            }
        }
        public void placeUnit(int x,int y)
        {
            board[x, y].SetSquare("<T>", true);
        }
        public void placeTerrain(int x, int y,string terrain)
        {
            board[x, y].SetSquare(terrain, false);
        }
        public void PlaceTerrainInCol(int y,int boundary,string terrain)//Down Direction
        {
           for(int i=0;i< boundary; i++)
            {
                board[i, y].SetSquare(terrain, false);
            }
           
        }

        public void PlaceBuilding(int x,int y,string HouseName,string Side)
        {
            //Place -1 consideration
                string formation;
                if (Side.Equals(">"))
                {
                    formation = " " + HouseName + Side;

                   
                }
                else
                {
                    formation = Side + HouseName + " ";
                }
            //Console.WriteLine(x + "" + y);
                board[x, y].SetSquare(formation, false);
            
        }
    }
}

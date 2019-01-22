using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chivary.Entity.Army;
using Chivary.Entity.Building;

namespace Chivary.Entity
{
    class GameManager
    {
        private Dice dice;
        private Board board;
        private Player[] player;
        private bool IsEnded;

        private bool IsPlayer1;
        private bool IsPlayer2;
        private string Player1Side;
        private string Player2Side;
        //Unit
        private SwordMan[] swordMen; //1
        private ArcherMan[] archerMen;//1
        private WarHorse[] warHorses;//2
        private ArcherHorse[] archerHorses;//2
        private WarElephant[] warElephants;//3
        private ArcherElephant[] archerElephants;//3
        private Ballista[] ballistas;//4
        private Cannon[] cannons;//4
        private ArcherShip[] archerShips;//4
        private BattleShip[] battleShips;//4
        //Building
        private Centre[] centres;
        private Barrack[] barracks; //1
        private House[] houses;//1
        private Transport[] transports;//2
        private Dock[] docks;//2
        private Stable[] stables; //3
        private Armory[] armories;//3
        private Tower[] towers;//4
        private Wall[] walls;//4
        private Workshop[] workshops;//5
        
        public GameManager() //Default Mode
        {
            IsEnded = false;
            dice = new Dice(1, 6); //Create normal dice
            board = new Board(16, 8); //Create board
            board.placeUnit(5, 5);
            //River
            board.PlaceTerrainInCol(7, 8, "~~~");
            board.PlaceTerrainInCol(8, 8, "~~~");
            //
            board.DisplayBoard(16, 8);
            
            player = new Player[2]; //2 player
            player[0] = new Player("Local", "Huy", true, ">");
            player[1] = new Player("Local", "Hưng", false, "<");
            SetFirstToGo();
            SetSide(player);
            DisplayGUI();
            centres = new Centre[2]; //2 Centre
            centres[0] = new Centre();
            centres[1] = new Centre();
            centres[0].SetHitPoint(3); //GDD: Centre has 3 hitpoint
            centres[1].SetHitPoint(3); //GDD: Centre has 3 hitpoint

            houses = new House[8];
            barracks = new Barrack[8];
            docks = new Dock[4];
            transports = new Transport[4];
            stables = new Stable[2];
            armories = new Armory[2];
            towers = new Tower[4];
            walls = new Wall[4];
            workshops = new Workshop[2];

            


            //centres[0].DisplayHitPoint();
            while (true)
            {
                if(IsPlayer1) //If Player 1 turn
                {
                    Console.WriteLine("Player 1\n");
                    int positionX = Convert.ToInt32(Console.ReadLine());
                    int positionY = Convert.ToInt32(Console.ReadLine());
                    board.PlaceBuilding(positionY, positionX, "C", ">");
                    IsPlayer2 = true;
                    IsPlayer1 = false;
                }
                else
                {
                    Console.WriteLine("Player 2");
                    int positionX = Convert.ToInt32(Console.ReadLine());
                    int positionY = Convert.ToInt32(Console.ReadLine());
                    board.PlaceBuilding(positionY, positionX, "C", "<");
                    IsPlayer1 = true;
                    IsPlayer2 = false;
                
                }
                board.DisplayBoard(16, 8);

            }
        }
        public void SetRule()
        {

        }
        // public void SetFirstToGo(Player[] player)
        public void SetFirstToGo()
        {
            Random _r = new Random();
            int n = _r.Next(0,2);
            if(n==0)
            {
                //player[0].SetTurn(true);
                //player[1].SetTurn(false);
                IsPlayer1 = true;
                IsPlayer2 = false;
            }
            else
            {
                //player[0].SetTurn(false);
                //player[1].SetTurn(true);
                IsPlayer1 = false;
                IsPlayer2 = true;
            }

        }
        public void SetSide(Player[] player)
        {
            Random _r = new Random();
            int n = _r.Next(0, 2);
            if (n == 0)
            {
                //player[0].SetSide(">");
                //player[1].SetSide("<");
            }
            else
            {
                //player[0].SetSide("<");
                //player[1].SetSide(">");
            }
        }
        public void DisplayGUI()
        {
            string ShareUnitPool = "======SHARED UNIT POOL=============\n" +
            "Sword Man (SM): " + "3" + "| Sword Horse (SH): " + "4" + "| War Elephant (WE): " + "5" + "| Arrow Ballista (AB): " + "5" + "| Archer Ship (AS): " + "5\n" +
            "Archer Man (AM): " + "3" + "| Archer Horse (AH): " + "4" + "| Archer Elephant (AE): " + "5" + "| Fire Catapult (FC): " + "5" + "| Battle Ship (BS): " + "5\n";
          

            Console.WriteLine(ShareUnitPool);
            string PlayerStat = "=======Player " + "1" + " Stat===========\n" +
                "Unit: " + "1/4" + " | " + "Centre HP: " + "1\n" +
                "Barrack (B): " + "3" + "| Transport (T): " + "4" + "| Stable (S): " + "5" + "| Tower (T): " + "5" + "| Workshop (W): " + "5\n" +
                 "House (H): " + "3" + "| Dock (D): " + "4" + "| Armory (S): " + "5" + "| Wall (M): " + "5" + "| Workshop (W): " + "5\n";

            Console.WriteLine(PlayerStat);
        }
        public void PlaceBuilding()
        {

        }
        
    }
}

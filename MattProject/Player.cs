using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattProject
{
    class Player : GameObject
    {
        public string playerName;


        public Player(string name, double xCord, double yCord, double zCord) : base(xCord, yCord, zCord)
        {
            this.playerName = name;
        }

        public void MoveX(double distance)
        {
            double currentX = this.vector.x;
            base.MoveX(distance);
            Console.WriteLine(playerName + " moved from " + currentX + " to " + this.vector.x);
        }

        public void MoveY(double distance)
        {
            double currentY = this.vector.y;
            base.MoveX(distance);
            Console.WriteLine(playerName + " moved from " + currentY + " to " + this.vector.y);
        }

        public void PrintPlayer()
        {
            Console.WriteLine("Player: " + playerName);

            this.vector.PrintVector3();
        }
    
    }
}



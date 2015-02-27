using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattProject
{
    class Vector3
    {
        public double x;
        public double y;
        public double z;

        public Vector3()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Vector3(double xCord, double yCord, double zCord)
        {
            this.x = xCord;
            this.y = yCord;
            this.z = zCord;
        }

        public void PrintVector3()
        {
            Console.WriteLine("X is at " + this.x);
            Console.WriteLine("Y is at " + this.y);
            Console.WriteLine("Z is at " + this.z);
        }

        public override string ToString()
        {
            return "{ " + this.x + ", " + this.y + ", " + this.z + " }"; 
        }
    }
}

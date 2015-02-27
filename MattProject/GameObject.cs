using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattProject
{
    class GameObject
    {
        public Vector3 vector;

        public GameObject(double xCord, double yCord, double zCord)
        {
            this.vector = new Vector3(xCord, yCord, zCord);
        }

        public void MoveX(double distance)
        {
            this.vector.x = this.vector.x + distance;
        }

        public void MoveY(double distance)
        {
            this.vector.y = this.vector.y + distance;
        }

        public void MoveZ(double distance)
        {
            this.vector.z = this.vector.z + distance;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is only the beginning!");
            GameObject testObject1 = new GameObject(1.0, 2.0, 3.0);
            testObject1.vector.PrintVector3();
            testObject1.MoveX(5);
            testObject1.vector.PrintVector3();
            testObject1.vector.x = testObject1.vector.x + 5;
            Console.WriteLine(testObject1.vector.ToString());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Player player1 = new Player("Matt", 1.0, 1.0, 1.0);
            player1.PrintPlayer();
            char willExit = 'N';
            while (willExit.Equals('N'))
            {
                Console.WriteLine("How far are we moving?");
                double movement = double.Parse(Console.ReadLine());
                player1.MoveX(movement);
                player1.PrintPlayer();
                Console.WriteLine("Would you like to exit? (Y/N)");
                willExit = char.Parse(Console.ReadLine());
            }
            

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Bomber Man Remake");

            Actor root = new Actor();
            game.Root = root;

            //## Set up game here ##//

            game.Run();
        }
    }
}

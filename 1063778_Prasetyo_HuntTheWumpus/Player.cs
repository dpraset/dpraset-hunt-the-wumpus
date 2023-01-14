using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1063778_Prasetyo_HuntTheWumpus
{
    public class Player
    {
        public int Arrows { get; private set; }

        public Player()
        {
            Initialize();
        }

        public void Initialize()
        {
            Arrows = 3;
        }
    }
}

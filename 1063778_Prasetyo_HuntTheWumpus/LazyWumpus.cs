using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1063778_Prasetyo_HuntTheWumpus
{
    public class LazyWumpus
    {
        public LazyWumpus()
        {
            State = WumpusState.Asleep;
        }
        public WumpusState State { get; set; }

        public enum WumpusState
        {
            Asleep,
            Awake
        }
        public void ArrowMisses()
        {
            if(State == WumpusState.Asleep)
            {
                State = WumpusState.Awake;
            }
            //insert code for wumpus move up to two rooms
        }
        public void DefeatTrivia()
        {
            //insert code for wumpus move up to three rooms
            
        }
        public void WumpusFallAsleep()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            //1, 6 is chance wumpus fall asleep, check with Parker about percentage
            if (random == 1 || random == 8)
            {
                if (State == WumpusState.Awake)
                {
                    State = WumpusState.Asleep;
                }
            }
        }

        public void WumpusMoves()
        {
            if(State == WumpusState.Awake)
            {
                //move wumpus one room per turn
                WumpusFallAsleep();
            }
            //check with Parker for all the naming and variables because I don't know what he named them
        }

    }
}

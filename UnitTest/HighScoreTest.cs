using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1063778_Prasetyo_HuntTheWumpus;
using FluentAssertions;
using System.IO;

namespace UnitTest
{

    class HighScoreTest
    {
        public String Name { get; set; }
        public String Cave { get; set; }
        public int Number { get; set; }
        
     
     public void Score()
        {
           
            
        }
        private void SaveHighScore()
        {
         
        }
        public HighScoreTest(String n, String c, int nb)
        {
            Name = n;
            Cave = c;
            Number = nb;
        }
    }
}

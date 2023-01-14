using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1063778_Prasetyo_HuntTheWumpus;
using FluentAssertions;

namespace UnitTest
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerObjectExists()
        {
            var player = new Player();

            player.Should().NotBeNull("The object should have been created");
        }

        [TestMethod]
        public void PlayerStartsWith3Arrows()
        {
            var player = new Player();
            //player.Arrows = 3; - DON'T DO THIS!

            player.Arrows.Should().Be(3, "player should start with 3 arrows");

        }
    }
}


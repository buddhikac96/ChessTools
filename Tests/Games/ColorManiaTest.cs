using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessTools.Games;

namespace Tests.Games
{
    [TestClass]
    public class ColorManiaTest
    {
        [TestMethod]
        public void GetScoreMessageTest()
        {
            var game = new ColorMania(5);
            Assert.AreEqual(game.getScoreMessage(5, 5), "AWESOME!");
        }
    }
}

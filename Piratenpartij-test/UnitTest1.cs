using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Piratenpartij.Obstacles;
using Piratenpartij.Obstacles.Enums;

namespace Piratenpartij_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Event()
        {
            Event e1 = new Event(EventType.PIRATES_SHIP);
            Assert.AreEqual(e1.EventType, EventType.PIRATES_SHIP);
        }
        
        [TestMethod]
        public void Test_Trips()
        {
            Assert.AreNotEqual(new Trip().Difficulty, 3);
        }

       
    }
}

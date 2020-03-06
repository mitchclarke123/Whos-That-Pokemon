using System.Linq;
using NUnit.Framework;
using PokedexWPF;

namespace PokedexTests
{
    
    public class Tests
    {   
        GameLogic _game;
        [SetUp]
        
        public void Setup()
        {
            _game = new GameLogic();
        }

        [Test]
        public void Test1()
        {
            var expected = 4;
            var result = _game.GetList().Count();
            Assert.AreEqual(expected, result);
        }
    }
}
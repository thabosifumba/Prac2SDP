using NUnit.Framework;

namespace Oware.Tests
{

    public class MockScoreHouse : IScoreHouse
    {
        public void AddSeed(Seed seed)
        {
            Seed l =  seed;
        }

        public int GetCount()
        {
            return 1;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1(){
            // ARRANGE:
            House h = new House(0,0);
            h.AddSeedInPot(new Seed());
            h.AddSeedInPot(new Seed());
            // ACT:
            h.ResetHouse();
            // ASSERT:
            Assert.AreEqual(4,h.GetCount(), "Houses must be reset to 4 seeds each");

        }

        [Test]
        public void Test2(){
            // ARRANGE:
            IScoreHouse k = new ScoreHouse();
            Player p1 = new Player("alice",k);
            Player p2 = new Player("bob", k);
            k = new MockScoreHouse();
            
            // ACT:
            k.AddSeed(new Seed());
            // ASSERT:
            Assert.AreEqual(1,k.GetCount(), "Score is correct");

        }
    }
}

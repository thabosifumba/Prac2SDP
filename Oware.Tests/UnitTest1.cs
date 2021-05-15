using NUnit.Framework;

namespace Oware.Tests
{
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
    }
}

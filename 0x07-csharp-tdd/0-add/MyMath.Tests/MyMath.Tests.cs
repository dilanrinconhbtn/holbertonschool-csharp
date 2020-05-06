using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests</summary>
    public class OperationsTests
    {
        [Test]
        public void Positives()
        {
            int result = Operations.Add(15, 42);

            Assert.AreEqual(57, result);
        }
        [Test]
        public void Negative()
        {
            int result = Operations.Add(-32, -5);

            Assert.AreEqual(-37, result);
        }
        [Test]
        public void NegativeResult()
        {
            int result = Operations.Add(5, -10);

            Assert.AreEqual(-5, result);
        }

        [Test]
        public void PositiveResult()
        {
            int result = Operations.Add(73, -3);

            Assert.AreEqual(70, result);
        }

         [Test]
        
        public void Zero()
        {
            int result = Operations.Add(10, -10);

            Assert.AreEqual(0, result);
        }
    }
}
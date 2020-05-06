using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Test c#</summary>
    public class OperationsTests
    {
        [Test]
        public void IntPositive()
        {
            int result = Operations.Add(1, 1);

            Assert.AreEqual(2, result);
        }
        [Test]
        public void IntNegative()
        {
            int result = Operations.Add(-5, -20);

            Assert.AreEqual(-25, result);
        }
        [Test]
        public void IntNegative()
        {
            int result = Operations.Add(-5, -20);

            Assert.AreEqual(-25, result);
        }
        [Test]
        public void ResultNegative()
        {
            int result = Operations.Add(10, -20);

            Assert.AreEqual(-10, result);
        }
        [Test]
        public void RestultPositive()
        {
            int result = Operations.Add(50, -20);

            Assert.AreEqual(30, result);
        }
        [Test]
        public void Zero()
        {
            int result = Operations.Add(50, -50);

            Assert.AreEqual(0, result);
        }
    }
}
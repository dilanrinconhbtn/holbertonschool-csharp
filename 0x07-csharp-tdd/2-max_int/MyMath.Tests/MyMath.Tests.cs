using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        /// <summary>Tests</summary>
        [Test]
        public void PositiveResult()
        {
            List<int> digits = new List<int> { 1, 2, 3, 4, 8, 2, 92, 102, 304, 705, 507, -803 }; 

            int result = Operations.Max(digits);

            Assert.AreEqual(705, result);
        }
        [Test]
        public void NegativeResult()
        {
            List<int> num = new List<int> { -803, -205, -301, -5 }; 

            int result = Operations.Max(num);

            Assert.AreEqual(-5, result);
        }
        [Test]
        public void ListEmpty()
        {
            List<int> num = new List<int>(); 

            int result = Operations.Max(num);

            Assert.AreEqual(0, result);
        }
        public void ListNull()
        {
            List<int> num = new List<int>(); 

            int result = Operations.Max(num);

            Assert.AreEqual(0, result);
        }
    }
}
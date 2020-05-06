using NUnit.Framework;

namespace MyMath.Tests
{
[TestFixture]
    /// <summary>Tests Alz</summary>
    public class MatrixTests
    {
        [Test]
        public void DivideByTwo()
        {
            int[,] matrix = new int[,] {{ 10, 12 }, { 3, 7 }, { 14, 9 }, { 100, 83 }};
            int n = 2;

            int[,] result = Matrix.Divide(matrix, n);

            Assert.AreEqual(new int[,] {{ 5, 6 }, { 1, 3 }, { 7, 4 }, { 50, 41 }}, result);
        }
        [Test]
        public void Zero()
        {
            int[,] matrix = new int[,] {{ 10, 12 }, { 3, 7 }, { 14, 9 }, { 100, 83 }};
            int n = 0;

            int[,] result = Matrix.Divide(matrix, n);

            Assert.AreEqual(null, result);
        }
        [Test]
        public void NumNull()
        {
            int[,] matrix = null;
            int n = 10;

            int[,] result = Matrix.Divide(matrix, n);

            Assert.AreEqual(null, result);
        }
    }
}
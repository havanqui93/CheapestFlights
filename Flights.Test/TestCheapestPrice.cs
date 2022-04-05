using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Test
{
    [TestFixture]
    public class TestCheapestPrice
    {
        private static IEnumerable<TestCaseData> ListTestCaseExpected()
        {
            yield return new TestCaseData(3, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } }, 0, 2, 1, 200);
            yield return new TestCaseData(3, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } }, 0, 2, 0, 500);
            yield return new TestCaseData(4, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 2, 0, 100 }, new int[] { 1, 3, 600 }, new int[] { 2, 3, 200 } }, 0, 3, 1, 700);
        }

        [Test, TestCaseSource("ListTestCaseExpected")]
        public void FindCheapestPrice_ReturnCorrectExpected(int n, int[][] flights, int src, int dst, int k, int priceExpected)
        {
            int result = CheapestFlights.FindCheapestPrice(n, flights, src, dst, k);
            Assert.AreEqual(priceExpected, result);
        }


        private static IEnumerable<TestCaseData> ListTestCaseException()
        {
            yield return new TestCaseData(5, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 2, 3, 300 }, new int[] { 2, 4, 150 }, new int[] { 3, 4, 120 }, new int[] { 0, 3, 150 } }, 0, 4, 0);
            yield return new TestCaseData(4, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 2, 0, 100 }, new int[] { 1, 3, 600 }, new int[] { 2, 3, 200 } }, 0, 3, 0);
        }

        [Test, TestCaseSource("ListTestCaseException")]
        public void FindCheapestPrice_ReturnException(int n, int[][] flights, int src, int dst, int k)
        {
            int result = CheapestFlights.FindCheapestPrice(n, flights, src, dst, k);
            Assert.AreEqual(-1, result);
        }

    }
}

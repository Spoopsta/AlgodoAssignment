using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedianAlgorithms;
using System.Linq;

namespace testCases
{
    [TestClass]
    public class TestCaseBF
    {
        static int[] testArr1 = new int[] { 4,5,6 };
        static int[] testArr2 = new int[] { 5, 5, 5 };
        static int[] testArr3 = new int[] { 4, 4, 6 };
        static int[] testArr4 = new int[] { 1,32,16 };
        static int[] testArr5 = new int[] { 16,16,8 };
        static int[] testArr6 = new int[] { 250,5,68 };

        static int[] testArr10 = testArr1.Concat(testArr1).ToArray();
        BruteForceMedian BF = new BruteForceMedian();

        //"Normal" Tests - standard, non-edge case inputs

        [TestMethod] public void TestNormalBF1(){ Assert.AreEqual(5, BF.getMedian(testArr1)); }
        [TestMethod] public void TestNormalBF2() { Assert.AreEqual(5, BF.getMedian(testArr2)); }
        [TestMethod] public void TestNormalBF3() { Assert.AreEqual(4, BF.getMedian(testArr3)); }
        [TestMethod] public void TestNormalBF4() { Assert.AreEqual(16, BF.getMedian(testArr4)); }
        [TestMethod] public void TestNormalBF5() { Assert.AreEqual(68, BF.getMedian(testArr6)); }

        
            
           
            

            //Assert.AreEqual(5, BF.getMedian(testArr10));

        
    }
}

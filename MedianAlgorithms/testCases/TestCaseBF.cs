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

        static int[] testArr11 = new int[] { 4, 5, 6, 4, 5, 6 };
        static int[] testArr12 = new int[] { 4, 5, 6, 5, 5, 5 };
        static int[] testArr13 = new int[] { 4, 5, 6, 4, 4, 6 };
        static int[] testArr14 = new int[] { 4, 5, 6, 1, 32, 16 };
        static int[] testArr15 = testArr1.Concat(testArr5).ToArray();
        static int[] testArr56 = testArr5.Concat(testArr6).ToArray();

        static int[] testArr100 = new int[] { 7, 6, 5, 4, 3, 2, 1 };
        static int[] testArr101 = new int[] { 400, 500, 100, 200, 600, 700, 300 };
        static int[] testArr102 = new int[] { 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        static int[] testArr1256 = testArr12.Concat(testArr56).ToArray();



        BruteForceMedian BF = new BruteForceMedian();

        //"Normal" Tests - standard, non-edge case inputs
        [TestMethod] public void TestNormalBF1(){ Assert.AreEqual(5, BF.getMedian(testArr1)); }
        [TestMethod] public void TestNormalBF2() { Assert.AreEqual(5, BF.getMedian(testArr2)); }
        [TestMethod] public void TestNormalBF3() { Assert.AreEqual(4, BF.getMedian(testArr3)); }
        [TestMethod] public void TestNormalBF4() { Assert.AreEqual(16, BF.getMedian(testArr4)); }
        [TestMethod] public void TestNormalBF5() { Assert.AreEqual(16, BF.getMedian(testArr5)); }
        [TestMethod] public void TestNormalBF6() { Assert.AreEqual(68, BF.getMedian(testArr6)); }
        //Normal tests - 6-length (even, small size)
        [TestMethod] public void TestNormalBF11() { Assert.AreEqual(5, BF.getMedian(testArr11)); }
        [TestMethod] public void TestNormalBF12() { Assert.AreEqual(5, BF.getMedian(testArr12)); }
        [TestMethod] public void TestNormalBF13() { Assert.AreEqual(4, BF.getMedian(testArr13)); }
        [TestMethod] public void TestNormalBF14() { Assert.AreEqual(5, BF.getMedian(testArr14)); }
        [TestMethod] public void TestNormalBF15() { Assert.AreEqual(6, BF.getMedian(testArr15)); }
        [TestMethod] public void TestNormalBF56() { Assert.AreEqual(16, BF.getMedian(testArr56)); }

        [TestMethod] public void TestNormalBF100() { Assert.AreEqual(4, BF.getMedian(testArr100)); }
        [TestMethod] public void TestNormalBF101() { Assert.AreEqual(400, BF.getMedian(testArr101)); }
        [TestMethod] public void TestNormalBF102() { Assert.AreEqual(1, BF.getMedian(testArr102)); }

        //Normal tests - Long
        [TestMethod] public void TestNormalBF1256() { Assert.AreEqual(5, BF.getMedian(testArr1256)); }




    }
}

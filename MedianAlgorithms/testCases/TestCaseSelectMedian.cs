using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedianAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace testCases
{
    [TestClass]
    public class TestCaseSelectMedian
    {
        static int[] testArr1 = new int[] { 4, 5, 6 };
        static int[] testArr2 = new int[] { 5, 5, 5 };
        static int[] testArr3 = new int[] { 4, 4, 6 };
        static int[] testArr4 = new int[] { 1, 32, 16 };
        static int[] testArr5 = new int[] { 16, 16, 8 };
        static int[] testArr6 = new int[] { 250, 5, 68 };

        static int[] testArr11 = new int[] { 4, 5, 6, 4, 5, 6 };
        static int[] testArr12 = new int[] { 4, 5, 6, 5, 5, 5 };
        static int[] testArr13 = new int[] { 4, 5, 6, 4, 4, 6 };
        static int[] testArr14 = new int[] { 4, 5, 6, 1, 32, 16 };
        static int[] testArr15 = testArr1.Concat(testArr5).ToArray();
        static int[] testArr56 = testArr5.Concat(testArr6).ToArray();

        static int[] testArr1256 = testArr12.Concat(testArr56).ToArray();

        SelectMedian SelMed = new SelectMedian();

        //"Normal" Tests - standard, non-edge case inputs
        [TestMethod] public void TestNormalSelMed1() { Assert.AreEqual(5, SelMed.getMedian(testArr1)); }
        [TestMethod] public void TestNormalSelMed2() { Assert.AreEqual(5, SelMed.getMedian(testArr2)); }
        [TestMethod] public void TestNormalSelMed3() { Assert.AreEqual(4, SelMed.getMedian(testArr3)); }
        [TestMethod] public void TestNormalSelMed4() { Assert.AreEqual(16, SelMed.getMedian(testArr4)); }
        [TestMethod] public void TestNormalSelMed5() { Assert.AreEqual(68, SelMed.getMedian(testArr6)); }
        //Normal tests - 6-length (even, small size)
        [TestMethod] public void TestNormalSelMed11() { Assert.AreEqual(5, SelMed.getMedian(testArr11)); }
        [TestMethod] public void TestNormalSelMed12() { Assert.AreEqual(5, SelMed.getMedian(testArr12)); }
        [TestMethod] public void TestNormalSelMed13() { Assert.AreEqual(5, SelMed.getMedian(testArr13)); }
        [TestMethod] public void TestNormalSelMed14() { Assert.AreEqual(6, SelMed.getMedian(testArr14)); }
        [TestMethod] public void TestNormalSelMed15() { Assert.AreEqual(8, SelMed.getMedian(testArr15)); }
        [TestMethod] public void TestNormalSelMed56() { Assert.AreEqual(16, SelMed.getMedian(testArr56)); }

        //Normal tests - Long
        [TestMethod] public void TestNormalSelMed1256() { Assert.AreEqual(6, SelMed.getMedian(testArr1256)); }

    }
}

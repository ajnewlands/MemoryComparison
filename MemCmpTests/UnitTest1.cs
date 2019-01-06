using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemoryComparison;

namespace MemCmpTests
{
    [TestClass]
    public class MemCmpTests
    {
        [TestMethod]
        public void TestMatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            Assert.AreEqual(true, new MemcmpComparison().Compare(A, B));
        }

        [TestMethod]
        public void TestMismatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            B[0] = 1;
            Assert.AreEqual(false, new MemcmpComparison().Compare(A, B));
        }
    }

    [TestClass]
    public class ForLoopTests
    {
        [TestMethod]
        public void TestMatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            Assert.AreEqual(true, new ForLoopComparison().Compare(A, B));
        }

        [TestMethod]
        public void TestMismatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            B[0] = 1;
            Assert.AreEqual(false, new ForLoopComparison().Compare(A, B));
        }
    }

    [TestClass]
    public class UnsafeForLoopTests
    {
        [TestMethod]
        public void TestMatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            Assert.AreEqual(true, new UnsafeForloopComparison().Compare(A, B));
        }

        [TestMethod]
        public void TestMismatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            B[0] = 1;
            Assert.AreEqual(false, new UnsafeForloopComparison().Compare(A, B));
        }
    }

    [TestClass]
    public class LinqTests
    {
        [TestMethod]
        public void TestMatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            Assert.AreEqual(true, new LinqComparison().Compare(A, B));
        }

        [TestMethod]
        public void TestMismatch()
        {
            byte[] A = new byte[1];
            byte[] B = new byte[1];
            B[0] = 1;
            Assert.AreEqual(false, new LinqComparison().Compare(A, B));
        }
    }
}

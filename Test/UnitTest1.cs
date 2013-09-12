using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFinal;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        public List<int> MakeList(params int[] ints)
        {
            return ints.ToList();
        }

        [TestMethod]
        public void Test1()
        {
            CollectionAssert.AreEqual(new List<int>(), Prime.Generate(1));
        }

        [TestMethod]
        public void Test2()
        {
            CollectionAssert.AreEqual(MakeList(2), Prime.Generate(2));
        }

        [TestMethod]
        public void Test3()
        {
            CollectionAssert.AreEqual(MakeList(3), Prime.Generate(3));
        }

        [TestMethod]
        public void Test4()
        {
            CollectionAssert.AreEqual(MakeList(2, 2), Prime.Generate(4));
        }

        [TestMethod]
        public void Test6()
        {
            CollectionAssert.AreEqual(MakeList(2, 3), Prime.Generate(6));
        }

        [TestMethod]
        public void Test8()
        {
            CollectionAssert.AreEqual(MakeList(2, 2, 2), Prime.Generate(8));
        }

        [TestMethod]
        public void Test9()
        {
            CollectionAssert.AreEqual(MakeList(3, 3), Prime.Generate(9));
        }
    }
}

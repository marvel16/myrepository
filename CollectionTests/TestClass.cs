using Collection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTests
{
    [TestClass]
    public class TestClass
    {
        public int[] teststorage;

        [TestInitialize]
        public void Init()
        {
            teststorage = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
        [TestMethod] //херня, надо переделать
        public void TestArray()
        {
            MyCollection test = new MyCollection();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            test.Add(9);
            test.Add(10);
            //Assert.AreEqual(teststorage, test.storage);
            Assert.IsTrue(teststorage.SequenceEqual(test.storage));
        }
    }
}

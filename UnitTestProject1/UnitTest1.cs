using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string actual = Program.CowConter(n);

            string expected = "1 корова";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int n = 11;
            string actual = Program.CowConter(n);

            string expected = "11 коров";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod101()
        {
            int n = 101;
            string actual = Program.CowConter(n);

            string expected = "101 корова";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod111()
        {
            int n = 111;
            string actual = Program.CowConter(n);

            string expected = "111 коров";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod0()
        {
            int n = 1000;
            string actual = Program.CowConter(n);

            string expected = "1000 коров";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod112()
        {
            int n = 112;
            string actual = Program.CowConter(n);

            string expected = "112 коров";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod11155()
        {
            int n = 123;
            string actual = Program.CowConter(n);

            string expected = "123 коровы";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod123()
        {
            int n = 11155;
            string actual = Program.CowConter(n);

            string expected = "11155 коров";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5590()
        {
            int n = 5590;
            string actual = Program.CowConter(n);

            string expected = "5590 коров";

            Assert.AreEqual(expected, actual);
        }
    }
}

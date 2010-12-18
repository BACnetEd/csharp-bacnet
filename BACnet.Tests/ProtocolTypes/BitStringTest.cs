using BACnet.ProtocolTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BACnet.Tests
{
    /// <summary>
    ///This is a test class for BitStringTest and is intended
    ///to contain all BitStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BitStringTest
    {
        enum TestBitstring
        {
            Flag1 = 0,
            Flag2 = 1,
            Flag3 = 2
        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void BitStringConstructorTest1()
        {
            BitString<TestBitstring> bs = new BitString<TestBitstring>(TestBitstring.Flag1, TestBitstring.Flag3);
            Assert.AreEqual(bs.Length, 3);
            Assert.AreEqual(bs[TestBitstring.Flag1], true);
            Assert.AreEqual(bs[TestBitstring.Flag2], false);
            Assert.AreEqual(bs[TestBitstring.Flag3], true);
        }

        [TestMethod()]
        public void BitStringConstructorTest2()
        {
            ulong flags = 128 + 32;
            BitString<TestBitstring> bs = new BitString<TestBitstring>(flags);
            Assert.AreEqual(bs.Length, 3);
            Assert.AreEqual(bs[TestBitstring.Flag1], true);
            Assert.AreEqual(bs[TestBitstring.Flag2], false);
            Assert.AreEqual(bs[TestBitstring.Flag3], true);
        }


        [TestMethod()]
        [DeploymentItem("BACnet.dll")]
        public void maskTest1()
        {
            Assert.AreEqual(BitString_Accessor<TestBitstring>.mask(0), 128ul);
            Assert.AreEqual(BitString_Accessor<TestBitstring>.mask(2), 32ul);
            Assert.AreEqual(BitString_Accessor<TestBitstring>.mask(15), 256ul);
        }


        [TestMethod()]
        public void op_ImplicitTest()
        {
            BitString<TestBitstring> bs = new BitString<TestBitstring>(128 + 32);
            BitString bs2 = bs;

            Assert.AreEqual(bs.Length, bs2.Length);
            Assert.AreEqual(true, bs2[0]);
            Assert.AreEqual(false, bs2[1]);
            Assert.AreEqual(true, bs2[2]);
        }

        [TestMethod()]
        public void FlagsTest1()
        {
            BitString<TestBitstring> bs = new BitString<TestBitstring>(TestBitstring.Flag1, TestBitstring.Flag3);
            Assert.AreEqual(bs.Flags, 160ul);
        }

        [TestMethod()]
        public void ItemTest1()
        {
            ulong flags = 128 + 32;
            BitString<TestBitstring> bs = new BitString<TestBitstring>(flags);
            Assert.AreEqual(bs.Length, 3);
            Assert.AreEqual(bs[TestBitstring.Flag1], true);
            Assert.AreEqual(bs[TestBitstring.Flag2], false);
            Assert.AreEqual(bs[TestBitstring.Flag3], true);
        }

        [TestMethod()]
        public void ItemTest2()
        {
            BitString<TestBitstring> bs = new BitString<TestBitstring>();
            bs[TestBitstring.Flag1] = true;
            bs[TestBitstring.Flag2] = false;
            bs[TestBitstring.Flag3] = true;
            Assert.AreEqual(bs.Flags, 160ul);
        }

        [TestMethod()]
        public void LengthTest1()
        {
            Assert.AreEqual(new BitString<TestBitstring>().Length, (byte)3);
        }

        /// <summary>
        ///A test for BitString Constructor
        ///</summary>
        [TestMethod()]
        public void BitStringConstructorTest()
        {
            BitString bs = new BitString(3, 128 + 32);
            Assert.AreEqual(bs.Length, 3);
            Assert.AreEqual(bs[0], true);
            Assert.AreEqual(bs[1], false);
            Assert.AreEqual(bs[2], true);
        }

        /// <summary>
        ///A test for mask
        ///</summary>
        [TestMethod()]
        public void maskTest()
        {
            Assert.AreEqual(BitString_Accessor.mask(1), 64ul);
            Assert.AreEqual(BitString_Accessor.mask(15), 256ul);
        }

        /// <summary>
        ///A test for Flags
        ///</summary>
        [TestMethod()]
        public void FlagsTest()
        {
            BitString bs = new BitString(3, 0);
            bs[0] = true;
            bs[2] = true;
            Assert.AreEqual(bs.Flags, 160ul);
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            BitString bs = new BitString(3, 32 + 128);
            Assert.AreEqual(true, bs[0]);
            Assert.AreEqual(false, bs[1]);
            Assert.AreEqual(true, bs[2]);
        }

        /// <summary>
        ///A test for Length
        ///</summary>
        [TestMethod()]
        public void LengthTest()
        {
            BitString bs = new BitString(3, 32 + 128);
            Assert.AreEqual(bs.Length, 3);
        }
    }
}

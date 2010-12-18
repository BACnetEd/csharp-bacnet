using BACnet.ProtocolTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BACnet.Tests
{
    
    
    /// <summary>
    ///This is a test class for EnumeratedTest and is intended
    ///to contain all EnumeratedTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EnumeratedTest
    {


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


        /// <summary>
        ///A test for Enumerated Constructor
        ///</summary>
        [TestMethod()]
        public void EnumeratedConstructorTest()
        {
            int value = 10;
            Enumerated target = new Enumerated(value);
            Assert.AreEqual(target.Value, value);
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        [TestMethod()]
        public void op_ImplicitTest()
        {
            Enumerated e = new Enumerated(10);
            int actual = e;
            Assert.AreEqual(10, actual);
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        [TestMethod()]
        public void op_ImplicitTest1()
        {
            int i = 10;
            Enumerated e = i;
            Assert.AreEqual(10, e.Value);
        }
    }
}

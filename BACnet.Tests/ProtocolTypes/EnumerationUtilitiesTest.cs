﻿/*  EnumerationUtilities test file
 *  Copyright (C) 2010 Loren Van Spronsen
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using BACnet.ProtocolTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BACnet.Tests
{
    public enum TestEnumeration
    {
        TestValue1 = 1,
        TestValue2 = 2,
        TestValue3 = 3
    }

    /// <summary>
    ///This is a test class for EnumerationUtilitiesTest and is intended
    ///to contain all EnumerationUtilitiesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EnumerationUtilitiesTest
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

        [TestMethod()]
        public void EnumerationUtilitiesConstructorTest()
        {
            Assert.AreEqual(1, EnumerationUtilities<TestEnumeration>.ToInt32(TestEnumeration.TestValue1));
            Assert.AreEqual(TestEnumeration.TestValue3, EnumerationUtilities<TestEnumeration>.FromInt32(3));
        }
    }
}

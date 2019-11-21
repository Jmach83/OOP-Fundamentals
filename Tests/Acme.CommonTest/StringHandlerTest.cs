using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValidTest()
        {
            string source = "SonicScrewdriver";
            string expected = "Sonic Screwdriver";

            string actual = StringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesWithExistingSpaces()
        {
            string source = "Sonic Screwdriver";
            string expected = "Sonic Screwdriver";

            string actual = StringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }
    }
}

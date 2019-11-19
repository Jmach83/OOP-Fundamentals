using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggings"
            };
            string expected = "Baggings, Bilbo";
            
            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggings"
            };
            string expected = "Baggings";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void LastNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            Customer c1 = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount += 1;

            Customer c2 = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount += 1; 
            
            Customer c3 = new Customer
            {
                FirstName = "Rosie"
            };
            Customer.InstanceCount += 1;

            //-- Act
            int actual = Customer.InstanceCount;

            //-- Assert
            Assert.AreEqual(3, actual);
        }
    }
}

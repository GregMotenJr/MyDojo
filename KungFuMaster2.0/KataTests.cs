using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KungFuMaster2._0
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class KataTests
    {

        [TestMethod]
        public void GetIntegersFromList_MixedValues_SouldPass_1()
        {
            //Arrange
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            //Act
            var actual = ListFilterer.GetIntegersFromList(list);

            //Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void GetIntegerFromList_MixedValues_ShouldPass_2()
        {
            //Arrange
            var list = new List<object>() { 1, "a", "b", 0, 15 };
            var expected = new List<int>() { 1, 0, 15 };

            //Act
            var actual = ListFilterer.GetIntegersFromList(list);

            //Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

    }

}

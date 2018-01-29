//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungFuMaster2._0
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(true, Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
        }

    }//END TEST CLASS
}//END NAMESPACE
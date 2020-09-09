using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.Int32Extensions.UnitTest
{
    [TestClass]
    public class CastToByteExtensionTest
    {
        [TestMethod]
        public void CastToByte()
        {
            for (var i = 0; i < 256; i++)
                Assert.AreEqual((byte) i, i.CastToByte());
        }

        [TestMethod]
        public void CastToByteCollection()
        {
            var intValues = new List<int> {10, 20, 30};
            var byteValues = new List<byte> {10, 20, 30};

            CollectionAssert.AreEqual(byteValues, intValues.CastToByte().ToList());
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarioWorld.GameOperatingSystem;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Image img = ImageHandler.LoadImageFrom(@"\res\thing.png");
        }
    }
}

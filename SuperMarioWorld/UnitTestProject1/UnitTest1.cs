using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarioWorld.GameOperatingSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SpriteSheet sprites = new SpriteSheet();
            Bitmap spriteSheet = new Bitmap(500, 500);
            sprites.setSpriteSheet();
        }
    }
}

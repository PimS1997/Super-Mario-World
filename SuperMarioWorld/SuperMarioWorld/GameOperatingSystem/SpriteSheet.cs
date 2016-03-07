using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SuperMarioWorld.GameOperatingSystem
{
    public class SpriteSheet
    {
        private Bitmap spriteSheet;

        public SpriteSheet()
        {


        }

        public void setSpriteSheet(Bitmap spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }

        public BufferedGraphics getTile(int xTile, int yTile, int width, int height)
        {
            BufferedGraphics sprite = spriteSheet.get(xTile, yTile, width, height);
            return sprite;
        }
    }
}

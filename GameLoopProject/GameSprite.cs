using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLoopProject
{
    public class GameSprite
    {
        public Bitmap SpriteImage { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int Velocity { get; set; }
        public GameSprite()
        {

        }
        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(SpriteImage, new RectangleF(X, Y, Width, Height));
        }
    
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLoopProject
{
    internal interface IGame
    {
        void Load();
        void Unload();
        void Update(TimeSpan gameTime);
        void Draw(Graphics gfx);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;
namespace GameLoopProject
{
    public class Game:IGame
    {
        private GameSprite playerSprite;
        public Size Resolution { get; set; }

        public void Load()
        {
            playerSprite = new GameSprite() { 
                SpriteImage=Properties.Resources.bomber_sprite,
                Width=playerSprite.SpriteImage.Width,
                Height=playerSprite.SpriteImage.Height,
                X=300,
                Y=300,
                Velocity=300
                };

        }
        public void Unload()
        {
            //Unload graphics
            //Turn off game music
        }
        public void Update(TimeSpan gameTime)
        {
            double gameTimeElapsed = gameTime.TotalMilliseconds / 1000;
            int moveDistance = (int)(playerSprite.Velocity * gameTimeElapsed);

            if ((Keyboard.GetKeyStates(Key.Right) & KeyStates.Down) > 0)
            {
                playerSprite.X += moveDistance;
            }
            else if ((Keyboard.GetKeyStates(Key.Left) & KeyStates.Down) > 0)
            {
                playerSprite.X -= moveDistance;
            }
            //I flip flopped the last 2
            else if ((Keyboard.GetKeyStates(Key.Up) & KeyStates.Down) > 0)
            {
                playerSprite.Y += moveDistance;
            }else if ((Keyboard.GetKeyStates(Key.Down)&KeyStates.Down)>0)
            {
                playerSprite.Y -= moveDistance;
            }
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(Color.CornflowerBlue), new Rectangle(/*X*/0, /*Y*/0, Resolution.Width, Resolution.Height));
            playerSprite.Draw(gfx);
        }

    }

    

}

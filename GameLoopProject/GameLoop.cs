using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLoopProject
{
    public class GameLoop
    {
        private Game _myGame;
        /// <summary>
        /// Status of GameLoop
        /// </summary>
        public bool IsRunning { get; private set; }
        /// <summary>
        /// Load Game into GameLoop
        /// </summary>
        /// <param name="gameObj"></param>
        public void Load(Game gameObj)
        {
            _myGame = gameObj;
        }
        public async void Start()
        {
            if (_myGame == null)
            {
                throw new ArgumentException("Game not loaded");
            }
                _myGame.Load();
                IsRunning = true;

                DateTime _previuosGameTime = DateTime.Now;

                while (IsRunning)
                {
                    TimeSpan GameTime = DateTime.Now - _previuosGameTime;
                    _previuosGameTime += GameTime;
                    _myGame.Update(GameTime);

                    await Task.Delay(8);
                }
            

        }

        public void Stop()
        {
            IsRunning = false;
            _myGame.Unload();
        }

        public void Draw(Graphics gfx)
        {
            _myGame.Draw(gfx);
        }
    }
}

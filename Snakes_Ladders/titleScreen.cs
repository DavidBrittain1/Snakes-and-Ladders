using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_Ladders
{
    class TitleScreen : IGameObject
    {
        private MenuScreenItem startButton;

        public TitleScreen()
        {
            startButton = new MenuScreenItem("Start", new Point(0, 0));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            startButton.Draw(spriteBatch);
        }

        public void Load(ContentManager contentManager, GraphicsDevice graphicsDevice)
        {
            startButton.Load(contentManager, graphicsDevice);
        }

        public void Update(GameTime gameTime)
        {
            startButton.Update(gameTime);
        }
    }
}

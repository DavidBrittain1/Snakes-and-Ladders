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
    class Board : IGameObject
    {
        private Texture2D boardTexture;
        Dice dice;
        Rectangle boardRectangle;
        
        public void Update(GameTime gameTime)
        {
            dice.Update(gameTime);            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(boardTexture, boardRectangle, Color.White);
            dice.Draw(spriteBatch);
        }

        public void Load(ContentManager contentManager, GraphicsDevice graphicsDevice)
        {
            boardRectangle = new Rectangle(0, 0, graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height);
            boardTexture = contentManager.Load<Texture2D>("Edited Snakes and Ladders Board");
            dice.Load(contentManager, graphicsDevice);
        }

        public Board()
        {
            dice = new Dice();
        }
    }
}

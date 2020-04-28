using Microsoft.Xna.Framework;
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
        Dice dice;
        public void Update(GameTime gameTime)
        {
                        
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            dice.Draw(spriteBatch);
        }

        public Board(Dice dice)
        {
            this.dice = dice;
        }
    }
}

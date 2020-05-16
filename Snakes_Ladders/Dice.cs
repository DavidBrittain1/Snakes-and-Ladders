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
    class Dice : IGameObject
    {
        int diceValue1, diceValue2;
        Rectangle dice1, dice2;
        Rectangle sourceRectangle1, sourceRectangle2, sourceRectangle3, sourceRectangle4, sourceRectangle5, sourceRectangle6;
        Random random;
        Texture2D dieTexture;
        public void Roll()
        {
            diceValue1 = random.Next(1, 7);
            diceValue2 = random.Next(1, 7);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            

            switch (diceValue1)
            {
                
                case 1:
                    spriteBatch.Draw(dieTexture, dice1, sourceRectangle1, Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(dieTexture, dice1, sourceRectangle2, Color.White);
                    break;
                case 3:
                    spriteBatch.Draw(dieTexture, dice1, sourceRectangle3, Color.White);
                    break;
                case 4:
                    spriteBatch.Draw(dieTexture, dice1, sourceRectangle4, Color.White);
                    break;
                case 5:
                    spriteBatch.Draw(dieTexture, dice1, sourceRectangle5, Color.White);
                    break;
                case 6:
                    spriteBatch.Draw(dieTexture, dice1, sourceRectangle6, Color.White);
                    break;
            }

            switch (diceValue2)
            {

                case 1:
                    spriteBatch.Draw(dieTexture, dice2, sourceRectangle1, Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(dieTexture, dice2, sourceRectangle2, Color.White);
                    break;
                case 3:
                    spriteBatch.Draw(dieTexture, dice2, sourceRectangle3, Color.White);
                    break;
                case 4:
                    spriteBatch.Draw(dieTexture, dice2, sourceRectangle4, Color.White);
                    break;
                case 5:
                    spriteBatch.Draw(dieTexture, dice2, sourceRectangle5, Color.White);
                    break;
                case 6:
                    spriteBatch.Draw(dieTexture, dice2, sourceRectangle6, Color.White);
                    break;
            }
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public void Load(ContentManager contentManager, GraphicsDevice graphicsDevice)
        {
            dieTexture = contentManager.Load<Texture2D>("die");
          
        }

        public Dice()
        {
            sourceRectangle1 = new Rectangle(0, 0, 128, 128);
            sourceRectangle2 = new Rectangle(128, 0, 128, 128);
            sourceRectangle3 = new Rectangle(256, 0, 128, 128);
            sourceRectangle4 = new Rectangle(384, 0, 128, 128);
            sourceRectangle5 = new Rectangle(512, 0, 128, 128);
            sourceRectangle6 = new Rectangle(640, 0, 128, 128);

           
            dice1 = new Rectangle(1, 1, 50, 50);
            dice2 = new Rectangle(1, 51, 50, 50);
            diceValue1 = 1;
            diceValue2 = 4;
            random = new Random();
        }
    }
}

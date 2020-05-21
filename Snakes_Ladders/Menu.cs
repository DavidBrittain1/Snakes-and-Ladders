using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Snakes_Ladders;

partial class Menu : IGameObject
{
    TitleScreen titleScreen;

    public Menu()
    {
        titleScreen = new TitleScreen();
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        titleScreen.Draw(spriteBatch);
    }

    public void Load(ContentManager contentManager, GraphicsDevice graphicsDevice)
    {
        titleScreen.Load(contentManager, graphicsDevice);
    }

    public void Update(GameTime gameTime)
    {
        titleScreen.Update(gameTime);
    }
}
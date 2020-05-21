using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Snakes_Ladders;

public class MenuScreenItem : IGameObject
{
    private string contents;
    private Rectangle menuRectangle;
    private SpriteFont menuFont;
    private bool isMouseOver;
    private Point position;

    public MenuScreenItem(string contents, Point position)
    {
        this.contents = contents;
        this.position = position;
        isMouseOver = false;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        if (isMouseOver)
        {
            spriteBatch.DrawString(menuFont, contents, menuRectangle.Location.ToVector2(), Color.Blue);
        }
        else
        {
            spriteBatch.DrawString(menuFont, contents, menuRectangle.Location.ToVector2(), Color.Black);
        }
    }

    public void Load(ContentManager contentManager, GraphicsDevice graphicsDevice)
    {
        menuFont = contentManager.Load<SpriteFont>("menuFont");
        
        var size = menuFont.MeasureString(contents).ToPoint();
        menuRectangle = new Rectangle(position, size);
    }

    public void Update(GameTime gameTime)
    {
        UpdateMouseOver(Mouse.GetState().Position);
    }

    private void UpdateMouseOver(Point mousePosition)
    {
        isMouseOver = menuRectangle.Contains(mousePosition.X, mousePosition.Y);
    }
}


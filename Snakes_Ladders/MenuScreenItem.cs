﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Snakes_Ladders;

public class MenuScreenItem : IGameObject
{
    private string contents;
    protected Rectangle menuRectangle;
    private SpriteFont menuFont;
    private bool isMouseOver;

    public MenuScreenItem(string contents, Point position)
    {
        this.contents = contents;
        menuRectangle = new Rectangle(position, Point.Zero);
        isMouseOver = false;
    }

    public bool IsPressed { get; set; }

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

    public virtual void Load(ContentManager contentManager, GraphicsDevice graphicsDevice)
    {
        menuFont = contentManager.Load<SpriteFont>("menuFont");
        menuRectangle.Size = menuFont.MeasureString(contents).ToPoint();
    }

    public void Update(GameTime gameTime)
    {
        var mouseState = Mouse.GetState();
        var mousePosition = mouseState.Position;

        if (menuRectangle.Contains(mousePosition.X, mousePosition.Y))
        {
            isMouseOver = true;
            IsPressed = mouseState.LeftButton == ButtonState.Pressed;
        }
        else
        {
            isMouseOver = false;
        }
    }
}


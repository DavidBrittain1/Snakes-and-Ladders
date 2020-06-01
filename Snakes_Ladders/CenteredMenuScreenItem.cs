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
    class CenteredMenuScreenItem : MenuScreenItem
    {
        bool isCenteredX;
        bool isCenteredY;
        public CenteredMenuScreenItem(string contents) : base(contents, Point.Zero)
        {
            isCenteredX = true;
            isCenteredY = true;
        }
        public CenteredMenuScreenItem(string contents, Axis centeredAxis, int nonCenteredPosition) : base(contents, Point.Zero)
        {
            if (centeredAxis == Axis.X)
            {
                isCenteredX = true;
                isCenteredY = false;
                menuRectangle.Y = nonCenteredPosition;
            }
            else 
            {
                isCenteredY = true;
                isCenteredX = false;
                menuRectangle.X = nonCenteredPosition;
            }
        }

        public override void Load(ContentManager contentManager, GraphicsDevice graphicsDevice)
        {
            base.Load(contentManager, graphicsDevice);
            if (isCenteredX)
            {
                var screenWidth = graphicsDevice.Viewport.Width;
                int centeredX = screenWidth / 2;
                int offset = menuRectangle.Width / 2;
                int moveToCentre = centeredX - offset;
                menuRectangle.X = moveToCentre;
            }
            if (isCenteredY)
            {
                var screenHeight = graphicsDevice.Viewport.Height;
                int centeredY = screenHeight / 2;
                int offset = menuRectangle.Height / 2;
                int moveToCentre = centeredY - offset;
                menuRectangle.Y = moveToCentre;
            }
        }

    }
}

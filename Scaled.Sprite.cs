
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

internal class ScaledSprite : Sprite
{

    public Rectangle Rect
    {
        get
        {
            return new Rectangle((int)_position.X, (int)_position.Y, 250, 200);
        }
    }
    public ScaledSprite(Texture2D texture, Vector2 position) : base(texture, position)
    {

    }
}
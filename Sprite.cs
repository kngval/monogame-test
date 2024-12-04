
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Sprite
{
    public Texture2D _texture;
    public Vector2 _position;

    public float SCALE = 5f;

    public Rectangle Rect
    {
        get
        {
            return new Rectangle((int)_position.X, (int)_position.Y, _texture.Width * (int)SCALE, _texture.Height * (int)SCALE);
        }
    }
    public Sprite(Texture2D texture, Vector2 position)
    {
        _texture = texture;
        _position = position;
    }

    public virtual void Update(GameTime gameTime)
    {

    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, Rect, Color.White);
    }
}
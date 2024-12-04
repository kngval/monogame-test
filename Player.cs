
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Player : Sprite
{


    public Player(Texture2D texture, Vector2 position) : base(texture, position) { }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            _position.Y += 5;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            _position.Y -= 5;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            _position.X -= 5;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            _position.X += 5;
        }
    }
}
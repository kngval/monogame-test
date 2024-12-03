
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Sprite {
    public Texture2D _texture;
    public Vector2 _position; 

    public Sprite(Texture2D texture, Vector2 position){
        _texture = texture;
        _position = position;
    }
}
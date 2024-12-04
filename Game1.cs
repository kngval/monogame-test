using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace mg_test;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;


    List<Sprite> sprite = new();

    Player player;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        Texture2D knight = Content.Load<Texture2D>("knight");
        Texture2D soldier = Content.Load<Texture2D>("Soldier");

        player = new Player(knight, new Vector2(100, 100));

        sprite.Add(new Sprite(knight, new Vector2(200, 100)));
        sprite.Add(player);

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        foreach (Sprite spr in sprite)
        {
            spr.Update(gameTime);
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

        foreach (Sprite spr in sprite)
        {
            
            spr.Draw(_spriteBatch);
        }

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}

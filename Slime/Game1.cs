using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame;

namespace Slime;

public class Game1 : Core
{
    private Texture2D _logo;
    private Texture2D _slime;

    public Game1() : base("Dungeon Slime", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();

        _logo = Content.Load<Texture2D>("images/logo");
        _slime = Content.Load<Texture2D>("images/pixil-frame-0");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        {
            Exit();
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Gray);

        // Rectangle Space = new(0, 0, 128, 128);
        // Rectangle End = new(150, 34, 458, 58);

        SpriteBatch.Begin(); // sortMode: SpriteSortMode.BackToFront

        // SpriteBatch.Draw(_logo,                     // Texture
        //     new Vector2(                            // Position
        //         Window.ClientBounds.Width,
        //         Window.ClientBounds.Height) * 0.5f,
        //     Space,                                   // SourceRectangle
        //     Color.White * 0.9f,                     // Color
        //     0.0f,                                   // Rotation (MathHelper.ToRadians(0))
        //     new Vector2(
        //         Space.Width,
        //         Space.Height) * 0.5f,               // Origin
        //     1.0f,                                   // Scale (bisa paka new Vector2(x, y))
        //     SpriteEffects.None,                     // Effects (Flip horizonal or vertical) SpriteEffects.FlipVertically | SpriteEffects.FlipHorizontally
        //     1.0f                                    // LayerDepth (seperti z-index di html)
        // );

        // SpriteBatch.Draw(_logo,                     // Texture
        //     new Vector2(                            // Position
        //         Window.ClientBounds.Width,
        //         Window.ClientBounds.Height) * 0.5f,
        //     End,                                   // SourceRectangle
        //     Color.White * 0.9f,                     // Color
        //     0.0f,                                   // Rotation (MathHelper.ToRadians(0))
        //     new Vector2(
        //         End.Width,
        //         End.Height) * 0.5f,               // Origin
        //     1.0f,                                   // Scale (bisa paka new Vector2(x, y))
        //     SpriteEffects.None,                     // Effects (Flip horizonal or vertical) SpriteEffects.FlipVertically | SpriteEffects.FlipHorizontally
        //     0.0f                                    // LayerDepth
        // );

        SpriteBatch.Draw(_logo,
            new Vector2(
                Window.ClientBounds.Width,
                Window.ClientBounds.Height) * 0.5f,
            null,
            Color.White,
            0.0f,
            new Vector2(
                _logo.Width,
                _logo.Height) * 0.5f,
            0.8f,
            SpriteEffects.None,
            0.0f
        );

        SpriteBatch.Draw(_slime,                     // Texture
            new Vector2(500.0f, 500.0f),               // Position,
            null,                                    // SourceRectangle
            Color.White,                             // Color
            0.0f,                                    // Rotation (MathHelper.ToRadians(0))
            new Vector2(
                _slime.Width,
                _slime.Height) * 0.5f,               // Origin
            5.0f,                                    // Scale (bisa paka new Vector2(x, y))
            SpriteEffects.None,                      // Effects (Flip horizonal or vertical) SpriteEffects.FlipVertically | SpriteEffects.FlipHorizontally
            0.0f                                     // LayerDepth
        );


        SpriteBatch.End();

        base.Draw(gameTime);
    }
}

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame;

namespace Slime;

/// <summary>
/// Class utama permainan "Dungeon Slime".
/// Menampilkan logo dan karakter slime di layar.
/// </summary>
public class Game1 : Core
{
    /// <summary>
    /// Tekstur logo "Se" yang ditampilkan di atas layar.
    /// </summary>
    private Texture2D _logo_se;

    /// <summary>
    /// Tekstur logo "MonoGame" yang ditampilkan di tengah layar.
    /// </summary>
    private Texture2D _logo_mg;

    /// <summary>
    /// Tekstur karakter slime yang akan dimainkan dalam permainan.
    /// </summary>
    private Texture2D _slime;

    /// <summary>
    /// Konstruktor untuk membuat game "Dungeon Slime" dengan ukuran 1280x720 pixel.
    /// Judul jendela akan menampilkan "Dungeon Slime".
    /// </summary>
    public Game1() : base("Dungeon Slime", 1280, 720, false)
    {

    }

    /// <summary>
    /// Dijalankan saat game pertama kali dimulai untuk setup awal.
    /// Memanggil method Initialize dari class parent (Core).
    /// </summary>
    protected override void Initialize()
    {
        base.Initialize();
    }

    /// <summary>
    /// Memuat semua konten (gambar, suara, dll) yang diperlukan oleh permainan.
    /// Dijalankan sekali pada saat game dimulai.
    /// </summary>
    protected override void LoadContent()
    {
        base.LoadContent();

        _logo_se = Content.Load<Texture2D>("images/logo");
        _logo_mg = Content.Load<Texture2D>("images/logomg");
        _slime = Content.Load<Texture2D>("images/pixil-frame-0");
    }

    /// <summary>
    /// Dijalankan setiap frame untuk memperbarui logika permainan (input, gerakan, dll).
    /// Mengecek apakah pemain menekan tombol Escape atau back button untuk keluar dari game.
    /// </summary>
    /// <param name="gameTime">Informasi tentang waktu permainan (delta time, total time)</param>
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        {
            Exit();
        }

        base.Update(gameTime);
    }

    /// <summary>
    /// Dijalankan setiap frame untuk menggambar semua objek visual ke layar.
    /// Menampilkan logo dan karakter slime pada posisi yang ditentukan.
    /// </summary>
    /// <param name="gameTime">Informasi tentang waktu permainan (delta time, total time)</param>
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Gray);

        Rectangle IconSourceRect = new(0, 0, 128, 128);
        Rectangle WordmarkSourceRect = new(150, 34, 458, 58);

        SpriteBatch.Begin(); // sortMode: SpriteSortMode.BackToFront

        SpriteBatch.Draw(_logo_mg,                     // Texture
            new Vector2(                            // Position
                Window.ClientBounds.Width,
                Window.ClientBounds.Height) * 0.5f,
            IconSourceRect,                                   // SourceRectangle
            Color.White * 0.9f,                     // Color
            0.0f,                                   // Rotation (MathHelper.ToRadians(0))
            new Vector2(
                IconSourceRect.Width,
                IconSourceRect.Height) * 0.5f,               // Origin
            1.0f,                                   // Scale (bisa paka new Vector2(x, y))
            SpriteEffects.None,                     // Effects (Flip horizonal or vertical) SpriteEffects.FlipVertically | SpriteEffects.FlipHorizontally
            1.0f                                    // LayerDepth (seperti z-index di html)
        );

        SpriteBatch.Draw(_logo_mg,                     // Texture
            new Vector2(                            // Position
                Window.ClientBounds.Width,
                Window.ClientBounds.Height) * 0.5f,
            WordmarkSourceRect,                                   // SourceRectangle
            Color.White * 0.9f,                     // Color
            0.0f,                                   // Rotation (MathHelper.ToRadians(0))
            new Vector2(
                WordmarkSourceRect.Width,
                WordmarkSourceRect.Height) * 0.5f,               // Origin
            1.0f,                                   // Scale (bisa paka new Vector2(x, y))
            SpriteEffects.None,                     // Effects (Flip horizonal or vertical) SpriteEffects.FlipVertically | SpriteEffects.FlipHorizontally
            0.0f                                    // LayerDepth
        );

        SpriteBatch.Draw(_logo_se,
            new Vector2(
                Window.ClientBounds.Width,
                0) * 0.5f,
            null,
            Color.White,
            0.0f,
            new Vector2(
                _logo_se.Width,
                0) * 0.5f,
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

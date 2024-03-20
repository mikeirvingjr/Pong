using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PongLibrary;

public class Paddle
{
    #region Properties

    public int X { get; set; }

    public int Y { get; set; }

    public int DeltaY { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public Color Color { get; set;  }

    public bool UseAI { get; set;  }

    public int Score { get; set; }

    #endregion

    #region Methods

    public void Update(GameTime gameTime)
    {
        if (DeltaY < 0)
            Y = (int)Math.Max(0, Y + DeltaY * gameTime.ElapsedGameTime.TotalSeconds);
        else
            Y = (int)Math.Min(/*VIRTUAL_HEIGHT*/ -Height, Y + DeltaY * gameTime.ElapsedGameTime.TotalMilliseconds);
    }

    public void UpdateScore(int amount) => Score += amount;

    public void ResetScore() => Score = 0;

    public void ToggleAI() => UseAI = !UseAI;

    public void Render(SpriteBatch spriteBatch)
    { 
        //Texture2D rectangle = new Texture2D(GraphicsDevice, 1, 1);
        //rectangle.SetData(new[] { Color.White });

        //// rectangle.Dispose(); in UnloadContent

        //spriteBatch.Draw()
    }

    #endregion

    public Paddle(int x, int y, int width, int height, Color color, bool useAI = false)
    {
        X = x;
        Y = y; 
        Width = width; 
        Height = height; 
        Color = color; 
        UseAI = useAI;
        DeltaY = 0;
        Score = 0;
    }
}

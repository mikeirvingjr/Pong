using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongLibrary;

public class Ball
{
    public int X { get; set; }

    public int Y { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public Color Color { get; set; }

    private int _deltaX;

    private int _deltaY;

    public void Reset()
    {
        Random random = new();

        // X = VIRTUAL_WIDTH / 2 - 2;
        // Y = VIRTUAL_HEIGHT / 2 - 2;

        _deltaX = random.Next(2) == 1 ? -100 : 100;
        _deltaY = random.Next(-50, 50);
    }

    public void Update(float deltaTime)
    {
        X += (int)(_deltaX * deltaTime);
        Y += (int)(_deltaY * deltaTime);
    }

    public Ball(int x, int y, int width, int height, Color color)
    {
        X = x;
        Y = y;
        Width = width; 
        Height = height;
        Color = color;
    }
}

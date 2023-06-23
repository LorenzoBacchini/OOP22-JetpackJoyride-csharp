using System.Net.Mime;

namespace SanchiEmanuele.JetpackJoyride.Impl;

using System.Drawing;

public class Sprite
{
    public Pair<int, int> OriginaDimension { get; private set; }
    public Pair<int, int> ScaledDimension { get; private set; }
    public Bitmap OriginalImage { get; private set; }
    public Bitmap ScaledImage { get; private set; }


    public Sprite(int width, int height, Bitmap img)
    {
        this.OriginaDimension = new Pair<int, int>(img.Width, img.Height);
        this.ScaledDimension = new Pair<int, int>(width, height);
        this.OriginalImage = img;
    }

    public void Scale()
    {
        this.ScaledImage = this.OriginalImage;
        Size size = new Size(ScaledDimension.x, ScaledDimension.y);
        this.ScaledImage = new Bitmap(OriginalImage, size);
    }
}
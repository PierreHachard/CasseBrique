using System;
using System.Windows.Shapes;
using System.Drawing;

public class Brick
{
    private static int longueur = 40;
    public static int largeur = 15;
    private int positionX;
    public int positionY;
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    private int resistance;

    public Brick(int x, int y, int resistance)
    {
        this.positionY = y;
        this.positionX = x;
        this.resistance = resistance;
    }

    public void dessinerBrick(Graphics g)
    {
        if (this.resistance == 1)
            g.FillRectangle(new SolidBrush(Color.Red), this.positionX, this.positionY, longueur, largeur);
        else if (this.resistance == 2)
            g.FillRectangle(new SolidBrush(Color.Green), this.positionX, this.positionY, longueur, largeur);
        else if (this.resistance == 3)
            g.FillRectangle(new SolidBrush(Color.Blue), this.positionX, this.positionY, longueur, largeur);
        g.DrawRectangle(new Pen(Color.Black, 1), this.positionX-1, this.positionY-1, longueur+1, largeur+1);
    }
}

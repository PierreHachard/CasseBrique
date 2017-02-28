using System;
using System.Windows.Shapes;
using System.Drawing;

public class Brick
{
    public static int longueur = 40;
    public static int largeur = 15;
    private int positionX;
    public int positionY;
    public int PositionX { get { return positionX; } }
    public int PositionY { get { return positionY; } }
    public int Longueur { get { return longueur; } }
    public int Largeur { get { return largeur; } }
    public int Resistance { get { return resistance; } }
    private int resistance;
    private System.Drawing.Rectangle rect;
    public System.Drawing.Rectangle Rect
    {
        get
        {
            return rect;
        }
    }


    public Brick(int x, int y, int resistance)
    {
        this.positionY = y;
        this.positionX = x;
        this.resistance = resistance;
        rect = new System.Drawing.Rectangle (positionX, positionY, longueur, largeur);
    }

    public void dessinerBrick(Graphics g)
    {
        if (this.resistance == 1)
            g.FillRectangle(new SolidBrush(Color.Red), this.positionX, this.positionY, longueur, largeur);
        else if (this.resistance == 2)
            g.FillRectangle(new SolidBrush(Color.Green), this.positionX, this.positionY, longueur, largeur);
        else if (this.resistance == 3)
            g.FillRectangle(new SolidBrush(Color.Blue), this.positionX, this.positionY, longueur, largeur);
        g.DrawRectangle(new Pen(Color.White, 1), this.positionX-1, this.positionY-1, longueur+2, largeur+2);
    }

    public void redessinerBrick(Graphics g)
    {
            this.resistance -= 1;
            if (this.resistance == 1)
                g.FillRectangle(new SolidBrush(Color.Red), this.positionX, this.positionY, longueur, largeur);
            else if (this.resistance == 2)
                g.FillRectangle(new SolidBrush(Color.Green), this.positionX, this.positionY, longueur, largeur);
            else if (this.resistance == 0)
            {
                g.Clear(Color.White);
            }
            if (resistance > 0)
                g.DrawRectangle(new Pen(Color.White, 1), this.positionX - 1, this.positionY - 1, longueur + 1, largeur + 1);
        }
}

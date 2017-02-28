using System;
using System.Windows.Shapes;
using System.Drawing;

public class Barre
{
    private int longueur;
    public const int largeur = 15;
    private int positionX;
    public const int positionY  = 580;
    public int PositionX { get { return positionX; } }
    public int PositionY { get { return positionY; } }
    public int Longueur { get { return longueur; } }
    public int Largeur { get { return largeur; } }
    private System.Drawing.Rectangle rect;
    public System.Drawing.Rectangle Rect
    {
        get
        {
            return rect;
        }
    }
    //public Graphics gBarre;

    public Barre(int x, int longueur)
    {
        this.longueur = longueur;
        this.positionX = x;
        rect = new System.Drawing.Rectangle(positionX, positionY,longueur,largeur);
    }

    public void dessinerBarre(Graphics g)
    {
        g.Clear(Color.White);
        g.FillRectangle(new SolidBrush(Color.Black), this.positionX, positionY, this.longueur, largeur);
    }

    public void deplacerBarre(int sourisX, int sourisY)
    {
        this.positionX = sourisX;
        if (sourisX < 0)
            this.positionX = 0;
        else if (sourisX > 440)
            this.positionX = 440;
        rect = new System.Drawing.Rectangle(positionX, positionY, longueur, largeur);

    }


}

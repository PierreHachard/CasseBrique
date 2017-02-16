using System;
using System.Windows.Shapes;
using System.Drawing;

public class Barre
{
    private int longueur;
    public static int largeur = 15;
    private int positionX;
    public static int positionY  = 500;
    public int Longueur { get; set; }
    public int PositionY { get; set; }

    public Barre(int x, int longueur)
    {
        this.longueur = longueur;
        this.positionX = x;
	}

    public void dessinerBarre(Graphics g)
    {
        g.FillRectangle(new SolidBrush(Color.Black), this.positionX, positionY, this.longueur, largeur);
    }


}

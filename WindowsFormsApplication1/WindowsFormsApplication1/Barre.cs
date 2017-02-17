using System;
using System.Windows.Shapes;
using System.Drawing;

public class Barre
{
    private int longueur;
    public static int largeur = 15;
    private int positionX;
    public static int positionY  = 580;
    public int Longueur { get; set; }
    public int PositionX { get; set; }
    //public Graphics gBarre;

    public Barre(int x, int longueur)
    {
        this.longueur = longueur;
        this.positionX = x;
	}

    public void dessinerBarre(Graphics g)
    {
        //this.gBarre.Clear(Color.White);
        g.FillRectangle(new SolidBrush(Color.Black), this.positionX, positionY, this.longueur, largeur);
        
    }

    public void deplacerBarre(int sourisX, int sourisY)
    {
        this.positionX = sourisX;
    }


}

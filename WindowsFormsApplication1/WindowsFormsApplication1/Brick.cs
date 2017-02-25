﻿using System;
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

    public void redessinerBrick(Graphics g)
    {
        this.resistance -= 1;
        if (this.resistance == 1)
            g.FillRectangle(new SolidBrush(Color.Red), this.positionX, this.positionY, longueur, largeur);
        else if (this.resistance == 2)
            g.FillRectangle(new SolidBrush(Color.Green), this.positionX, this.positionY, longueur, largeur);
        else if (this.resistance == 3)
            g.FillRectangle(new SolidBrush(Color.Blue), this.positionX, this.positionY, longueur, largeur);
        else if (this.resistance == 0)
            g.Clear(Color.White);
        g.DrawRectangle(new Pen(Color.Black, 1), this.positionX - 1, this.positionY - 1, longueur + 1, largeur + 1);
    }
}

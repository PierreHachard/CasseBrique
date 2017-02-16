using System;
using System.Windows.Shapes;

public class Brick
{
    private Rectangle brique;
    private int hp;

	public Brick( Rectangle rec, int resistance)
	{
        this.brique = rec;
        this.hp = resistance;
	}


}

using System;

public class Rectangle
{
    private double side;

	public void RectangleMth(double side)
	{
        this.side = side;
    }
    public double area()
    {
        return Math.Pow(this.side, 2);
    }
    public double around()
    {
        return 4 * side;
    }
}

public class Square
{
    private double p;
    private double l;

    public void SquareMth(double p, double l)
    {
        this.p = p;
        this.l = l;
    }
    public double area()
    {
        double area = p*l;
        return area;
    }
    public double around()
    {
        double around = 2*(p+l);
        return around;
    }

}
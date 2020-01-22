using System;

public class Circles
{
    private int radius;

    public void CircleMth(int radius)
    {
        this.radius = radius;
    }
    public double area()
    {
        return 3.14 * (Math.Pow(radius, 2));
    }
    public double around()
    {
        return 3.14 * (radius * 2);
    }
}

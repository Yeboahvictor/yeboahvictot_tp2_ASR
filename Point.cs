using System;


public class Point 
{
    private int x;
    private int y;
    private int z;


   
    public int X
    {
        get{return x;}
    }

  
    public int Y
    {
        get{return y;}
    }

 
    public int Z
    {
        get{return z;}
    }



    public Point(int x = 0, int y = 0, int z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }


   
    public void Transalation(int scalarX, int scalarY, int scalarZ) {
        this.x += scalarX;
        this.y += scalarY;
        this.z += scalarZ;
    }



    public bool egal(Point otherPoint)

    {
        if (this.x - otherPoint.x == 0 && (this.y - otherPoint.y == 0) && (this.z - otherPoint.z == 0)) return true;
        return false;
    }


    public bool alignés(Point p1, Point p2)
    {
        Point pp1 = new Point(p1.x - this.x, p1.y - this.y, p1.z - this.z);
        Point pp2 = new Point(p2.x - this.x, p2.y - this.y, p2.z - this.z);
        int k1 = pp1.x / pp2.x;
        int k2 = pp1.y / pp2.y;
        int k3 = pp1.z / pp2.z;
        return (k1 == k2 && k1 == k3 && k2 == k3);
    }
}
}
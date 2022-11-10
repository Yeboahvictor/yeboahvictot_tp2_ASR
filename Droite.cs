public class Droite
{
    private Point start;
    private Point end;
   
    public Droite(Point start, Point end)
    {
        
        this.start = start;
        this.end = end;
    }

   
    public Point Start
    {
        
        get{return start;}
    }

   
    public Point End
    {
        
        get{return end;}
    }

  
    public float slope
    {
        
        get{
            return (end.Y - start.Y)/(end.X - start.X);
        }
    }

   
    public float yIntercept{
        
        get{
            return start.Y - (slope * start.X);
        }
    }

   
    public bool parallele (Droite otherDroite) 
    {
        
        if (this.slope == otherDroite.slope && (this.yIntercept != otherDroite.yIntercept)) return true;
        return false;
    }

    
    public bool apartien(Point point)
    {
        
        if (point.Y == (slope * point.X) + yIntercept) return true;
        return false;
    }


    public bool apartien (Droite droite)
    {
        
        if ((this.start.X * droite.end.Y) - (this.end.Y * droite.start.X) == 0) return true;
        return false;
    }
}
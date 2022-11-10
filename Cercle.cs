using System;

public class Cercle: Ellipse
{
    
    public Cercle(Droite droite): base(droite, droite){}

    
    new public double Superficie() 
    {

        double distance = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y), 2));
        return 3.142 * distance;
    }

   
    new public double circonference()
    {
        double distance = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y), 2));
        return 2 * 3.142 * (distance/2);
    }
}
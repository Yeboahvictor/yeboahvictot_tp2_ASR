using System;

public class Ellipse
{
    protected Droite diametre1;
    protected Droite diametre2;

  
    public Ellipse(Droite premierDiametre, Droite deuxiemeDiametre)
    {
        this.diametre1 = premierDiametre;
        this.diametre2 = deuxiemeDiametre;
    }

   
    public double Superficie()
    {
        double distance1 = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y),2 ));
        double distance2 = Math.Sqrt(Math.Pow((diametre2.End.X - diametre2.Start.X), 2) + Math.Pow((diametre2.End.Y - diametre2.Start.Y), 2));

        return 3.142 * (distance1/2) * (distance2/2);
    }

    
    public double circonference()
    {
        double distance1 = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y), 2));
        double distance2 = Math.Sqrt(Math.Pow((diametre2.End.X - diametre2.Start.X), 2) + Math.Pow((diametre2.End.Y - diametre2.Start.Y), 2));

        return 3.142 * ((distance1/2) + (distance2/2));
    }
}
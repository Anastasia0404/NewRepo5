namespace Application;

public class Converter
{
    private double usd;
    private double eur;
    private double rub;

    public Converter(double usd, double eur, double rub)
    {
        this.usd = usd;
        this.eur = eur;
        this.rub = rub;
    }

    public double USD
    {
        get { return usd; }
    }

    public double EUR
    {
        get { return eur; }
    }

    public double RUB
    {
        get { return RUB; }
    }

    public double EurToUah(double value)
    {
        return value * eur;
    }
    
    public double UasToUah(double value)
    {
        return value * usd;
    }
    
    public double RubToUah(double value)
    {
        return value * rub;
    }
    
    public double UahToUsd(double value)
    {
        return value / usd;
    }
    
    public double UahToEur(double value)
    {
        return value / eur;
    }
    
    public double UahToRub(double value)
    {
        return value / rub;
    }
}
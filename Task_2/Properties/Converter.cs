using System.Reflection;
using System.Runtime.InteropServices;

class Converter
{
    private double usd1;
    private double eur2;
    private double pln3;
    public Converter( double usd, double eur, double pln )
    {
        usd1 = usd;
        eur2 = eur;
        pln3 = pln;
    }

    public double ConvertertoGRN(double sumaingrn, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return sumaingrn * usd1;
            case "eur":
                return sumaingrn * eur2;
            case "pln":
                return sumaingrn * pln3;
            default:
                throw new AmbiguousMatchException("Wrong currency");
                
        }
    }
    public double ConverterfromGRN(double sumaingrn, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return sumaingrn / usd1;
            case "eur":
                return sumaingrn / eur2;
            case "pln":
                return sumaingrn / pln3;
            default:
                throw new AmbiguousMatchException("Wrong currency");
                
        }
    }
}
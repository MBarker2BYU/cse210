public class Fraction
{
    public Fraction(int numerator, int denominator)
    {
        m_Numerator = numerator;
        m_Denominator = denominator;
    }

    public Fraction() : this(1, 1)  
    {}

    public Fraction(int numerator) : this(numerator, 1)  
    {}

    private int m_Numerator;
    private int m_Denominator;

    public int Numerator 
    { 
        get => m_Numerator;
        set => m_Numerator = value; 
    }

    public int Denominator 
    { 
        get => m_Denominator; 
        set => m_Denominator = value; 
    }

    public string GetFractionString()
    {
        return $"{m_Numerator}/{m_Denominator}";
    }

    public double GetDecimalValue()
    {
        return (double) m_Numerator / m_Denominator;
    }    
        
}
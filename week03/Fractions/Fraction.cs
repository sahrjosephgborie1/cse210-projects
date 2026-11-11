public class Fraction
{
    private int _top;
    private int _bottom;

    // Fraction()
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // Fraction(int wholeNumber)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
    }
    // Fraction(int top, int bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // GetTop()
    // SetTop(int top)
    // GetBottom()
    // SetBottm(int Bottom)

    // GetFractionString() string
    //  GetDecimalValue() double
}
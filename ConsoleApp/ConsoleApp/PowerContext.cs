namespace ConsoleApp;

public class PowerContext
{
    private IPowerStrategy _powerStrategy;

    public PowerContext(IPowerStrategy powerStrategy)
    {
        _powerStrategy = powerStrategy;
    }

    public int CalculateIntegerPower(int number, int exponent)
    {
        return _powerStrategy.CalculateIntegerPower(number, exponent);
    }
}

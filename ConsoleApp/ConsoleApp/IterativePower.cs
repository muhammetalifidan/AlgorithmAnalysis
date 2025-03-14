namespace ConsoleApp;

class IterativePower: IPowerStrategy
{
    public int CalculateIntegerPower(int number, int exponent)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= number;
        }
        return result;
    }
}

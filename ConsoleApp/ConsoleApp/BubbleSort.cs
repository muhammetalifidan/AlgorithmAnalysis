namespace ConsoleApp;

public class BubbleSort: ISortingAlgorithm
{
    public List<int> Sort(List<int> numbers)
    {
        List<int> tempNumbers = new List<int>(numbers);

        for (int i = 0; i < tempNumbers.Count - 1; i++)
        {
            for (int j = 0; j < tempNumbers.Count - 1 - i; j++)
            {
                if (tempNumbers[j] > tempNumbers[j + 1])
                {
                    int temp = tempNumbers[j];
                    tempNumbers[j] = tempNumbers[j + 1];
                    tempNumbers[j + 1] = temp;
                }
            }
        }
        return tempNumbers;
    }
}

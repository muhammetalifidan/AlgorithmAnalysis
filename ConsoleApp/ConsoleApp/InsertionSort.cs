using ConsoleApp;

public class InsertionSort : ISortStrategy
{
    public List<int> Sort(List<int> numbers)
    {
        List<int> tempNumbers = new List<int>(numbers);

        for (int i = 1; i < tempNumbers.Count; i++)
        {
            int current = tempNumbers[i];
            int j = i - 1;

            while (j >= 0 && tempNumbers[j] > current)
            {
                tempNumbers[j + 1] = tempNumbers[j];
                j--;
            }
            tempNumbers[j + 1] = current;
        }

        return tempNumbers;
    }
}
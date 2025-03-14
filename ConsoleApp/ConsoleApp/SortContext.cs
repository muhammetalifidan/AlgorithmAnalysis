namespace ConsoleApp;

public class SortContext
{
    private ISortStrategy _sortingAlgorithm;

    public SortContext(ISortStrategy sortingAlgorithm)
    {
        _sortingAlgorithm = sortingAlgorithm;
    }

    public List<int> Sort(List<int> numbers)
    {
        return _sortingAlgorithm.Sort(numbers);
    }
}

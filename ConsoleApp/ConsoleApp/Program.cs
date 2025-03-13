using ConsoleApp;

var displayService = new SortingDisplayService();

var bubbleSort = new BubbleSort();
var sortingContext = new SortingContext(bubbleSort);
var algorithmName = bubbleSort.GetType().Name;
List<int> numbersBeforeBubbleSort = new List<int> { 5, 3, 8, 4, 2 };
List<int> numbersAfterBubbleSort = sortingContext.Sort(numbersBeforeBubbleSort);
displayService.DisplayResults(algorithmName, numbersBeforeBubbleSort, numbersAfterBubbleSort);


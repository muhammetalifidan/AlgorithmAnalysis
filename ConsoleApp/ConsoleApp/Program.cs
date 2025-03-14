using ConsoleApp;

var displayService = new SortingDisplayService();

/* Bubble Sort */
var bubbleSort = new BubbleSort();
var sortingContext = new SortContext(bubbleSort);
var algorithmName = bubbleSort.GetType().Name;
List<int> numbersBeforeBubbleSort = new List<int> { 5, 3, 8, 4, 2 };
List<int> numbersAfterBubbleSort = sortingContext.Sort(numbersBeforeBubbleSort);
displayService.DisplayResults(algorithmName, numbersBeforeBubbleSort, numbersAfterBubbleSort);

/* Insertion Sort */
var insertionSort = new InsertionSort();
sortingContext = new SortContext(insertionSort);
algorithmName = insertionSort.GetType().Name;
List<int> numbersBeforeInsertionSort = new List<int> { 5, 3, 8, 4, 2 };
List<int> numbersAfterInsertionSort = sortingContext.Sort(numbersBeforeInsertionSort);
displayService.DisplayResults(algorithmName, numbersBeforeInsertionSort, numbersAfterInsertionSort);
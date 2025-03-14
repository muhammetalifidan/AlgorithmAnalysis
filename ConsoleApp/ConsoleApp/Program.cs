using ConsoleApp;

var displayService = new DisplayService();

/* Bubble Sort */
var bubbleSort = new BubbleSort();
var sortingContext = new SortContext(bubbleSort);
var algorithmName = bubbleSort.GetType().Name;
List<int> numbersBeforeBubbleSort = new List<int> { 5, 3, 8, 4, 2 };
List<int> numbersAfterBubbleSort = sortingContext.Sort(numbersBeforeBubbleSort);
displayService.DisplaySortingResults(algorithmName, numbersBeforeBubbleSort, numbersAfterBubbleSort);

/* Insertion Sort */
var insertionSort = new InsertionSort();
sortingContext = new SortContext(insertionSort);
algorithmName = insertionSort.GetType().Name;
List<int> numbersBeforeInsertionSort = new List<int> { 5, 3, 8, 4, 2 };
List<int> numbersAfterInsertionSort = sortingContext.Sort(numbersBeforeInsertionSort);
displayService.DisplaySortingResults(algorithmName, numbersBeforeInsertionSort, numbersAfterInsertionSort);

/* Integer Power */
var iterativePower = new IterativePower();
var powerContext = new PowerContext(iterativePower);
int number = -3, exponent = 5;
int result = powerContext.CalculateIntegerPower(number, exponent);
displayService.DisplayPowerResults(number, exponent, result);

/* Maximum Subarray */

/* Maximum Subarray Sum */

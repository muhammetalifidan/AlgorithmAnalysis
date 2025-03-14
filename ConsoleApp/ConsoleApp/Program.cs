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
int powerResult = powerContext.CalculateIntegerPower(number, exponent);
displayService.DisplayPowerResults(number, exponent, powerResult);

/* Maximum Subarray Kadane*/
var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

var maxSubarrayKadane = new MaxSubarrayKadane();
var maxSubarrayContext = new MaxSubarrayContext(maxSubarrayKadane);
var maxSubarrayResult = maxSubarrayContext.FindMaxSubarray(nums);

string method1 = "MaxSubArrayDivideConquer";
string divideConquer = method1.Substring(11);
string divideConquerSpaced = string.Concat(divideConquer.Select(x => char.IsUpper(x) ? " " + x : x.ToString())).TrimStart();
displayService.DisplayMaxSubarrayResults(divideConquerSpaced, nums, maxSubarrayResult);

/* Maximum Subarray Divide Conquer */
nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

var maxSubarrayDivideConquer = new MaxSubarrayDivideConquer();
maxSubarrayContext = new MaxSubarrayContext(maxSubarrayDivideConquer);
maxSubarrayResult = maxSubarrayContext.FindMaxSubarray(nums);

string method2 = "MaxSubArrayKanade";
string kanade = method2.Substring(11);
displayService.DisplayMaxSubarrayResults(kanade, nums, maxSubarrayResult);
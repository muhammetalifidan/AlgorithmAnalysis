﻿namespace ConsoleApp;

public class DisplayService
{
    public void DisplaySortingResults(string algorithmName, List<int> numbersBeforeSorting, List<int> numbersAfterSorting)
    {
        Console.WriteLine($"----------- {algorithmName} sorting algorithm -----------\n");
        string beforeList = string.Join(", ", numbersBeforeSorting);
        string afterList = string.Join(", ", numbersAfterSorting);
        Console.WriteLine($"Numbers before sorting: {beforeList}");
        Console.WriteLine($"Numbers after sorting : {afterList}");
        Console.WriteLine();
    }

    public void DisplayPowerResults(double number, double exponent, double result)
    {
        Console.WriteLine($"----------- Power calculation -----------\n");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Exponent: {exponent}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine();
    }
}

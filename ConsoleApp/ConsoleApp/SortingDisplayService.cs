using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SortingDisplayService
    {
        public void DisplayResults(string algorithmName, List<int> numbersBeforeSorting, List<int> numbersAfterSorting)
        {
            Console.WriteLine($"----------- {algorithmName} sorting algorithm -----------\n");
            string beforeList = string.Join(", ", numbersBeforeSorting);
            string afterList = string.Join(", ", numbersAfterSorting);
            Console.WriteLine($"Numbers before sorting: {beforeList}");
            Console.WriteLine($"Numbers after sorting : {afterList}");
            Console.WriteLine();
        }
    }
}

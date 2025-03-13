using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SortingContext
    {
        private ISortingAlgorithm _sortingAlgorithm;

        public SortingContext(ISortingAlgorithm sortingAlgorithm)
        {
            _sortingAlgorithm = sortingAlgorithm;
        }

        public List<int> Sort(List<int> numbers)
        {
            return _sortingAlgorithm.Sort(numbers);
        }
    }
}

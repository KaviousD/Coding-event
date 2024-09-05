using Microsoft.AspNetCore.Mvc;
using Pizzaria.Models;
using System.Collections.Generic;

namespace Pizzaria.Controllers
{
    public class SortingController : Controller
    {
        public IActionResult InsertionSort()
        {
            var pairs = new List<KeyValuePairModel>
            {
                new KeyValuePairModel { Key = 5, Value = "apple" },
                new KeyValuePairModel { Key = 2, Value = "banana" },
                new KeyValuePairModel { Key = 9, Value = "cherry" }
            };
            var sortedStates = InsertionSort(pairs);
            return View(sortedStates);
        }

        private List<List<KeyValuePairModel>> InsertionSort(List<KeyValuePairModel> pairs)
        {
            var states = new List<List<KeyValuePairModel>> { new List<KeyValuePairModel>(pairs) };
            for (int i = 1; i < pairs.Count; i++)
            {
                var key = pairs[i];
                int j = i - 1;
                while (j >= 0 && pairs[j].Key > key.Key)
                {
                    pairs[j + 1] = pairs[j];
                    j--;
                }
                pairs[j + 1] = key;
                states.Add(new List<KeyValuePairModel>(pairs));
            }
            return states;
        }
    }
}

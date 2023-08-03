using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ZemReusables
{
    public class WeightedListHelper
    {
        public T RandomPick<T>(IEnumerable<T> sequence, SeededRandom seededRandom, Func<T, float> weightSelector)
        {
            float totalWeight = sequence.Sum(weightSelector);
            float targetWeight = seededRandom.NextFloat() * totalWeight;
            float currentWeightIndex = 0;
            foreach (var item in from weightedItem in sequence select new { Value = weightedItem, Weight = weightSelector(weightedItem) })
            {
                float weight = Mathf.Max(0F, item.Weight);
                currentWeightIndex += weight;
                //If we've hit or passed the weight we are after for this item then it's the one we want.
                //if a weight for an item is 0, then the item should never be selected.
                //Using >= will give 0 weight items a very slim chance to be selected.
                if (currentWeightIndex > targetWeight)
                    return item.Value;
            }
            return default;
        }
    }
}

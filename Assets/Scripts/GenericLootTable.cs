//Generic implementation of a loot selection system
//Adds together the weight of all the items and then gives them value ranges based on the priors max weight
//EG
/*
 * Egg = 2
 * Toast = 5
 * Ranges: Egg 0-2, Toast 2-5
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericLootTable<T, U> where T : GenericItem<U>
{
    [SerializeField]
    public List<T> lootDropItems;

    float probabilityWeightTotal;

    //Ensures all items in the table have proper weighting and then gives a percentage for nicer viewing in the inspector
    public void validateTable()
    {
        if(lootDropItems != null && lootDropItems.Count > 0)
        {
            float currentProbabilityMaximum = 0f;

            foreach(T lootDropItem in lootDropItems)
            {
                if(lootDropItem.probabilityWeight < 0f)
                {
                    Debug.Log("You cant have a negative weight, setting to 0");
                    lootDropItem.probabilityWeight = 0f;
                }
                else
                {
                    lootDropItem.probabilityRangeFrom = currentProbabilityMaximum;
                    currentProbabilityMaximum += lootDropItem.probabilityWeight;
                    lootDropItem.probabilityRangeTo = currentProbabilityMaximum;
                }
            }
            probabilityWeightTotal = currentProbabilityMaximum;

            foreach(T lootDropItem in lootDropItems)
            {
                lootDropItem.probabilityPercent = ((lootDropItem.probabilityWeight) / probabilityWeightTotal) * 100;
            }
        }
    }

    //Generates a random number and then selects the item with that range and then returns it
    public T PickLootItem()
    {
        float pickedNumber = Random.Range(0, probabilityWeightTotal);

        foreach(T lootDropItem in lootDropItems)
        {
            if(pickedNumber > lootDropItem.probabilityRangeFrom && pickedNumber < lootDropItem.probabilityRangeTo)
            {
                return lootDropItem;
            }
        }
        Debug.LogError("Item couldnt be picked");
        return lootDropItems[0];
    }
}

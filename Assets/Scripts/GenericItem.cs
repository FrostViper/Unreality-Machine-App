using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericItem<T>
{
    public T item;

    public float probabilityWeight;

    public float probabilityPercent;

    [HideInInspector]
    public float probabilityRangeFrom;
    [HideInInspector]
    public float probabilityRangeTo;
}

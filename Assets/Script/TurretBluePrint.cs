﻿using UnityEngine;
using System.Collections;


[System.Serializable]
public class TurretBluePrint {

    public GameObject prefab;
    public int cost;

    public int GetSellAmount ()
    {
        return cost/2;
    }
}

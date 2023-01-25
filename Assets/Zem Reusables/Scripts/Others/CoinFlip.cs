using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlip
{
    public bool Flip()
    {
        return Random.Range(0, 2) > 0;
    }
}

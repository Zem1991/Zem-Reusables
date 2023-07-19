using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZemReusables
{
    public class CoinFlip
    {
        public bool Flip()
        {
            return Random.Range(0, 2) > 0;
        }
    }
}

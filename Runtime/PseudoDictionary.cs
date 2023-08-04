using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZemReusables
{
    //[System.Serializable]
    public abstract class PseudoDictionary<K, V>
    {
        [Header("List")]
        [SerializeField] protected List<PseudoItem<K, V>> items = new();

        public virtual V Get(K key)
        {
            return items.Find(item => item.Key.Equals(key)).Value;
        }
    }
}

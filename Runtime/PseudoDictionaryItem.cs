using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZemReusables
{
    [System.Serializable]
    public struct PseudoItem<K, V>
    {
        [SerializeField] private K key;
        [SerializeField] private V value;

        public K Key { get => key; set => key = value; }
        public V Value { get => value; set => this.value = value; }
    }
}

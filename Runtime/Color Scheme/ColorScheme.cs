using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZemReusables
{
    [CreateAssetMenu(menuName = "Zem Reusables/ColorScheme")]
    public class ColorScheme : ScriptableObject
    {
        [SerializeField] private Color main = Color.blue;

        public Color GetMain()
        {
            return Get(1F);
        }

        public Color GetHighlight()
        {
            return Get(0.5F);
        }

        public Color GetUI()
        {
            return Get(0.75F);
        }

        private Color Get(float a)
        {
            Color result = main;
            result.a = a;
            return result;
        }
    }
}

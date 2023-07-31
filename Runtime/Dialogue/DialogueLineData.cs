using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZemReusables
{
    [CreateAssetMenu(menuName = "Zem Reusables/Dialogue/Line")]
    public class DialogueLineData : ScriptableObject
    {
        //[SerializeField] private CharacterData character;
        [SerializeField][TextArea] private string text;
        //public CharacterData Character { get => character; private set => character = value; }
        public string Text { get => text; private set => text = value; }
    }
}

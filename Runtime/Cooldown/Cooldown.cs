using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZemReusables
{
    [Serializable]
    public class Cooldown
    {
        [SerializeField] private Action action;
        [SerializeField][Min(0F)] private float value;
        [SerializeField][Min(0F)] private float current;

        public Cooldown(Action action, float value)
        {
            this.action = action;
            this.value = value;
            Reset();
        }

        public void Reset()
        {
            current = 0;
        }

        public void Fill()
        {
            current = value;
        }

        public void Update(float deltaTime)
        {
            current = Mathf.Clamp(current - deltaTime, 0, value);
        }

        public bool CanDoAction()
        {
            return current <= 0;
        }

        public bool DoAction()
        {
            bool canDo = CanDoAction();
            if (!canDo) return false;
            Fill();
            action.Invoke();
            return true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZemReusables
{
    public interface ICooldownUpdater
    {
        public void UpdateCooldowns(float deltaTime);
    }
}

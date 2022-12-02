using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICooldownUpdater
{
    public void UpdateCooldowns(float deltaTime);
}

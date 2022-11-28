using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSchemeOnPlayerTag
{
    private ColorScheme color;
    public ColorScheme Color { get => color; private set => color = value; }

    public ColorSchemeOnPlayerTag(ColorScheme color)
    {
        Color = color;
    }

    public void Apply(GameObject target)
    {
        Color mainColor = Color.GetMain();
        var sprites = target.GetComponentsInChildren<SpriteRenderer>();
        foreach (var item in sprites)
        {
            if (!item.CompareTag("Player")) continue;
            item.color = mainColor;
        }
    }

    public void Apply(List<GameObject> targetList)
    {
        foreach (var item in targetList)
        {
            Apply(item);
        }
    }
}

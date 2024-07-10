using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LookAtExtension 
{
    public static void LookAt2D(this Transform transform,Vector2 pTarget) 
    {
        Vector2 position = pTarget - (Vector2)transform.position;
        float tan = Mathf.Atan2(position.y, position.x);
        transform.rotation = Quaternion.Euler(0, 0, tan * Mathf.Rad2Deg - 90);
    }
}

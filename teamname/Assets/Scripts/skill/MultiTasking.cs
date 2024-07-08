using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTasking : MonoBehaviour
{
    private Database playerData;

    public void Select()
    {
        playerData.attack *= 1.75f;
        playerData.attackSpeed *= 1.75f;
    }
}

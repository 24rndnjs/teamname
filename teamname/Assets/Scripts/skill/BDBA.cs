using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDBA : MonoBehaviour
{
    private Database playerData;

    public void Select()
    {
        playerData.DmgMultiplier += 0.5f;
    }
}

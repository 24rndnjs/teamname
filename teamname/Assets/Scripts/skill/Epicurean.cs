using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epicurean : MonoBehaviour
{
    private Database playerData;

    public void Select()
    {
        playerData.Vamp += 0.1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "player Data", order = 51)]
public class Database : ScriptableObject
{
    public string name;
    public float attack;
    public float defense;


}

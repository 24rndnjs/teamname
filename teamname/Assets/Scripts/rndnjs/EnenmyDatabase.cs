using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDatabase", menuName = "EnemyData", order = 51)]
public class EnenmyDatabase : ScriptableObject
{
    public string name;
    public float speed;
    public int defense;
    public float hp;

    public float attack;
}

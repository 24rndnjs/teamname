using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "player Data", order = 51)]
public class Database : ScriptableObject
{
    public string name;
    public float attack;
    public float defense;
    public float CriticalDamage;
    public float CriticalChance;
    public float moveSpeed;
    public float atkSpeed;
    public float Vamp;
    public float DmgMultiplier;




}

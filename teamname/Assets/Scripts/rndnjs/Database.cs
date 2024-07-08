using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "player Data", order = 51)]
public class Database : ScriptableObject
{
    public string NAME;

    // �⺻ ����
    public float ATK;
    public float DEF;
    public float MoveSpeed;
    public float AtkSpeed;
    
    // ���� ����
    public float attack; // ����) attack = ATK * Rate
    public float defense;
    public float moveSpeed;
    public float attackSpeed;

    // % ����
    public float Vamp;
    public float CritDamage;
    public float CritChance;
    public float DmgMultiplier;
}

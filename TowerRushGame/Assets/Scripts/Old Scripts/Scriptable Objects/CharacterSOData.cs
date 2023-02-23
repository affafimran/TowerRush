using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/CharacterData")]
public class CharacterSOData : ScriptableObject
{
    public GameObject unit;
    public int health;
    public rarity rarityType;
    public int armor;
    public float speed;
    public int cost;
    public float cooldown_timer;
    public float range;
}

public enum rarity
{
    Common,Rare,Epic,Legendary
};
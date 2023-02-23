using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Rarity
{
    Common,
    Rare,
    Epic,
    Legendary
}

public class Soldier :MonoBehaviour
{
    int soldierID;
    int castleID;
    int health;
    int xpPoints;
    int soldierLevel;
    int summonCost;
    int upgradeCost;
    string soldierType;
    int hitPoints;
    string factionName;
    string soldierName;

    Rarity soldierRarity;




    public int CastleID { get => castleID; set => castleID = value; }
    public int Health { get => health; set => health = value; }
    public int XpPoints { get => xpPoints; set => xpPoints = value; }
    public int SoldierLevel { get => soldierLevel; set => soldierLevel = value; }
    public int SummonCost { get => summonCost; set => summonCost = value; }
    public int UpgradeCost { get => upgradeCost; set => upgradeCost = value; }
    public string SoldierType { get => soldierType; set => soldierType = value; }
    public int HitPoints { get => hitPoints; set => hitPoints = value; }
    public string FactionName { get => factionName; set => factionName = value; }
    public string SoldierName { get => soldierName; set => soldierName = value; }
    public int SoldierID { get => soldierID; set => soldierID = value; }
    public Rarity SoldierRarity { get => soldierRarity; set => soldierRarity = value; }
}

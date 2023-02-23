using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kingdom : MonoBehaviour
{
    public int KingdomID { get; set; }
    public List<int> CastleList { get; set; } = new List<int>();
    public float ConqueredRegionProgress { get; set; }
    public string KingdomName { get; set; }
    public string KingdomLore { get; set; }

    public bool KingdomLocked;
    public void AddCastleToKingdom(int _id)
    {
        CastleList.Add(_id);
        Debug.Log("Kingdom.cs: Added castle to kingdom : " + _id);
    }

}
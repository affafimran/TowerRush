using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawner : MonoBehaviour
{
    public int soldierID;
    GameObject soldierPrefab = null;

    public void SpawnOnClick()
    {

        soldierPrefab = Castle.Instance.SoldierGameObjectToSpawn(soldierID);

        print(soldierPrefab.GetComponent<Soldier>().FactionName);
        Transform transfom = WaypointHandler.Instance.returnPosition();
        Instantiate(soldierPrefab, transfom.position, transfom.rotation);
    }
}
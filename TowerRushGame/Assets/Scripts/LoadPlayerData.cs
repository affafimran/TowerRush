using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LoadPlayerData : MonoBehaviour
{







    public void PopulateData()
    {


    }

    public void Save()
    {
        //SaveManager savedata = new SaveManager();

        //string jsondata = JsonUtility.ToJson(savedata);

        //Debug.Log(jsondata);
        SaveSystem.SaveGame();

    }

    public void CheckDataCount()
    {
        Debug.LogFormat("Soldiers: {0} - Castles: {1} - Kingdoms: {2}", GameManager.Instance.GetAllSoldiers().Count(), GameManager.Instance.GetAllCastles().Count(), GameManager.Instance.GetAllKingdoms().Count());
    }
}

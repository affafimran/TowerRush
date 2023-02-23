using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Kingdom> KingdomsList = new List<Kingdom>();
    public List<Soldier> SoldiersList = new List<Soldier>();
    public List<Castle> CastlesList = new List<Castle>();

    Dictionary<string, List<Castle>> CastlesInKingdomList = new Dictionary<string, List<Castle>>();
    Dictionary<string, List<Soldier>> SoldiersInCastleList = new Dictionary<string, List<Soldier>>();


    List<PowerUp> PowerupsList = new List<PowerUp>();
    public int resourcesCount = 24;
    public static GameManager Instance;

    public delegate void OnResourcesAddition();
    public static event OnResourcesAddition OnResourcesAdded;


    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        LoadGameData.OnLoadDataComplete += PlaceCastlesAndSoldiers;
    }

    private void OnDisable()
    {
        LoadGameData.OnLoadDataComplete -= PlaceCastlesAndSoldiers;

    }


    public Kingdom GetKingdom(int kingdom_id)
    {

        Kingdom _kingdom = KingdomsList.Find(x => x.KingdomID == kingdom_id);
        return _kingdom;
    }

    public Castle GetCastle(int castle_id)
    {
        Castle _castle = CastlesList.Find(x => x.CastleID == castle_id);
        return _castle;
    }

    public Soldier GetSoldier(int soldier_id)
    {
        Soldier _soldier = SoldiersList.Find(x => x.SoldierID == soldier_id);
        return _soldier;
    }


    public void AddResources(int amountToAdd)
    {
        resourcesCount += amountToAdd;
        OnResourcesAdded?.Invoke();
    }

    bool CanPlaceSoldier(int _resourceCost)
    {
        return _resourceCost < resourcesCount;
    }

    public void AddKingdom(Kingdom _kingdom)
    {
        KingdomsList.Add(_kingdom);
        //Debug.Log("Added a kingdom: to Gamemanager Pool" + _kingdom.KingdomID);
    }

    public void AddCastle(Castle _castle)
    {
        CastlesList.Add(_castle);
           Debug.Log("Added a castle: to Gamemanager Pool" + _castle.CastleID);

    }

    public void AddSoldier(Soldier _soldier)
    {
        SoldiersList.Add(_soldier);
        //Debug.Log("Added a Soldier: to Gamemanager Pool: "+_soldier.SoldierID);
    }

    public int GetResourcesCount()
    {

        return resourcesCount;
    }

    public List<Kingdom> GetAllKingdoms()
    {
        return KingdomsList;
    }
    public List<Soldier> GetAllSoldiers()
    {
        return SoldiersList;
    }
    public List<Castle> GetAllCastles()
    {
        return CastlesList;
    }

    string GetCastleNameForSoldier(int _id)
    {

       // Debug.Log("GetCastleNameForSoldier(): Soldier Count " + SoldiersList.Count + " ID: " + _id);
        Castle castle = CastlesList.Find(x => x.SoldiersList.Contains(_id));

        if (castle == null)
            Debug.Log("Can't find castle");
        string _castleName = castle.CastleName;
        return _castleName;
    }


    string GetKingdomNameForCastle(int _id)
    {
        Debug.Log("GetKingdomNameForCastle(): Castle Count " + CastlesList.Count + " ID: " + _id);

        string _kingdomName = KingdomsList.Find(x => x.CastleList.Contains(_id)).KingdomName;
        return _kingdomName;
    }

    public void PlaceSoldierInCastleDictionary(int _soldierID)
    {
        Soldier _soldier = GetSoldier(_soldierID);
        List<Soldier> _soldiersList;
        string _castleName = GetCastleNameForSoldier(_soldierID);
        Debug.Log("Trying to put a soldier in castle: " + _castleName);

        if (SoldiersInCastleList.ContainsKey(_castleName))
            _soldiersList = new List<Soldier>(SoldiersInCastleList[_castleName]);
        else
            _soldiersList = new List<Soldier>();

        _soldiersList.Add(_soldier);
        SoldiersInCastleList[_castleName] = _soldiersList;
        Debug.LogFormat("Placed Soldier: {0} in Castle: {1} ", _soldierID, _castleName);
    }


    public void PlaceCastleInKingdomDictionary(int _castleID)
    {
        Castle _castle = GetCastle(_castleID);
        List<Castle> _castlesList;
        string _kingdomName = GetKingdomNameForCastle(_castleID);
        if (CastlesInKingdomList.ContainsKey(_kingdomName))
            _castlesList = new List<Castle>(CastlesInKingdomList[_kingdomName]);
        else
            _castlesList = new List<Castle>();


        _castlesList.Add(_castle);
        CastlesInKingdomList[_kingdomName] = _castlesList;
        Debug.LogFormat("Placed Castle:{0} in Kingdom: {1} ", _castleID, _kingdomName);

    }

    void PlaceCastlesAndSoldiers()
    {
        Debug.Log("PlaceCastlesAndSoldiers()");
        for (int i = 0; i < SoldiersList.Count; i++)
        {
                PlaceSoldierInCastleDictionary(SoldiersList[i].SoldierID);
        }

        for (int i = 0; i < CastlesList.Count; i++)
        {
            PlaceCastleInKingdomDictionary(CastlesList[i].CastleID);
        }
    }
}

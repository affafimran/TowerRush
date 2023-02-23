using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class SaveManager
{


    #region gamemanager

    public List<SaveSystemKingdom> kingdomList = new List<SaveSystemKingdom>();
    public List<SaveSystemSoldier> AllSoldiersList = new List<SaveSystemSoldier>();
    public List<SaveSystemCastle> castleList = new List<SaveSystemCastle>();
    public List<SaveSystemPowerup> powerList = new List<SaveSystemPowerup>();
    public int resourcesCount = 24;
    #endregion


    public SaveManager()
    {

        #region Saving Kingdoms
        List<Kingdom> _allKingdoms = GameManager.Instance.GetAllKingdoms();
        for (int i = 0; i < _allKingdoms.Count; i++)
        {
            Kingdom kd = _allKingdoms[i]; // just keeping a reference to store currently processed kingdom

            SaveSystemKingdom _saveKingdom = new SaveSystemKingdom();
            _saveKingdom.KingdomID = kd.KingdomID;
            _saveKingdom.ConqueredRegionProgress = kd.ConqueredRegionProgress;
            _saveKingdom.KingdomName = kd.KingdomName;
            _saveKingdom.KingdomLore = kd.KingdomLore;
            _saveKingdom.KingdomLocked = kd.KingdomLocked;
            _saveKingdom.CastleList = new List<int>();

            List<int> _cList = kd.CastleList;

            for (int j = 0; j < _cList.Count; j++)
            {
                _saveKingdom.CastleList.Add(_cList[j]);
            }
            kingdomList.Add(_saveKingdom);
        }

        #endregion

        #region Saving Soldiers
        List<Soldier> _allSoldiers = GameManager.Instance.GetAllSoldiers();
        for (int i = 0; i < _allSoldiers.Count; i++)
        {
            SaveSystemSoldier _saveSoldier = new SaveSystemSoldier();
            Soldier _s = _allSoldiers[i];

            _saveSoldier.CastleID = _s.CastleID;
            _saveSoldier.XpPoints = _s.XpPoints;
            _saveSoldier.SoldierLevel = _s.SoldierLevel;
            _saveSoldier.SummonCost = _s.SummonCost;
            _saveSoldier.UpgradeCost = _s.UpgradeCost;
            _saveSoldier.SoldierType = _s.SoldierType;
            _saveSoldier.HitPoints = _s.HitPoints;
            _saveSoldier.FactionName = _s.FactionName;
            _saveSoldier.SoldierName = _s.SoldierName;
            _saveSoldier.SoldierID = _s.SoldierID;
            _saveSoldier.SoldierRarity = _s.SoldierRarity.ToString();

            AllSoldiersList.Add(_saveSoldier);

        }

        #endregion



        #region Saving Castles

        List<Castle> _allCastleList = GameManager.Instance.GetAllCastles();

        for (int i = 0; i < _allCastleList.Count; i++)
        {
            Castle _c = _allCastleList[i];

            SaveSystemCastle _saveCastle = new SaveSystemCastle();

            _saveCastle.CastleID = _c.CastleID;
            _saveCastle.KingdomID = _c.KingdomID;
            _saveCastle.CastleTier = _c.CastleTier;
            _saveCastle.ProductionCapacity = _c.ProductionCapacity;
            _saveCastle.ProductionTime = _c.ProductionTime;


            List<int> _castleSoldiers = _c.SoldiersList;
            _saveCastle.SoldiersList = new List<int>();
            for (int j = 0; j < _castleSoldiers.Count; j++)
            {
                _saveCastle.SoldiersList.Add(_castleSoldiers[j]);
            }
            castleList.Add(_saveCastle);
        }

        #endregion


    }


    [System.Serializable]
    public class SaveSystemSoldier
    {

        #region soldiers
        public int CastleID;
        public int XpPoints;
        public int SoldierLevel;
        public int SummonCost;
        public int UpgradeCost;
        public string SoldierType;
        public int HitPoints;
        public string FactionName;
        public string SoldierName;
        public int SoldierID;
        public string SoldierRarity;


        #endregion

    }




    [System.Serializable]
    public class SaveSystemKingdom
    {

        #region kingdom

        public int KingdomID;
        public List<int> CastleList;
        public float ConqueredRegionProgress;
        public string KingdomName;
        public string KingdomLore;
        public bool KingdomLocked;


        #endregion
    }



    [System.Serializable]
    public class SaveSystemCastle
    {


        public int CastleID;
        public int KingdomID;
        public List<int> SoldiersList;
        public List<int> PowersList;
        public int CastleTier;


        #region Production
        public int ProductionCapacity;
        public float ProductionTime;
        #endregion
    }


    [System.Serializable]
    public class SaveSystemPowerup
    {


    }
}

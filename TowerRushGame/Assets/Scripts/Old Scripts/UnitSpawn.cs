using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoBehaviour
{
    public List<GameObject> army;
    GameObject unit;
    public GameObject pos;
    List<string> names = new List<string> { "Soldier", "Archer", "Mage", "Engineer", "cleric", "Bard" };
    List<int> cost = new List<int> { 15, 15, 20, 20, 25, 30 };
    float timer;
    int index;
    float time = 5f;
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > time)
        {
            index = Random.Range(0, 5);
            createUnit(index);
            timer = 0;
            time += 2;
        }
    }


    public void createUnit(int index)
    {
        int coin = PlayerPrefs.GetInt("EnemyGold");
        if (cost[index] < coin)
        {
            //print(names[index]);
            unit = Instantiate(army[index], pos.transform.position, pos.transform.rotation);
            unit.SetActive(true);
            unit.gameObject.tag = "enemy";
            PlayerPrefs.SetInt("EnemyGold", coin - cost[index]);

        }

    }


    // Start is called before the first frame update
}

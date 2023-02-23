using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDeath : MonoBehaviour
{
    public static UnitDeath instance;

    void Start()
    {
        instance = this;
    }

    public void checkDeath()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("player");
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("enemy");
        for (int i = 0; i < player.Length; i++)
        {
            player[i].GetComponent<UnitMovement>().enabled = true;
            player[i].transform.GetChild(0).GetComponent<Animator>().SetTrigger("LoopAll");
            player[i].transform.GetChild(0).GetComponent<Animator>().Play("Walk");
            player[i].GetComponent<UnitMovement>().isDead = false;
            player[i].GetComponent<UnitMovement>().isFighting = false;
            player[i].GetComponent<UnitMovement>().isStanding = false;

        }
        for (int i = 0; i < enemy.Length; i++)
        {

            enemy[i].GetComponent<UnitMovement>().enabled = true;
            enemy[i].transform.GetChild(0).GetComponent<Animator>().SetTrigger("LoopAll");
            enemy[i].transform.GetChild(0).GetComponent<Animator>().Play("Walk");
            enemy[i].GetComponent<UnitMovement>().isDead = false;
            enemy[i].GetComponent<UnitMovement>().isFighting = false;
            enemy[i].GetComponent<UnitMovement>().isStanding = false;
        }
    }
}

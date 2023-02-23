using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    public int health;
    public static UnitMovement instance;
    public bool isFighting = false;
    public bool isDead = false;
    public bool isStanding = false;
    public string warrior_class;
    void Start()
    {
        instance = this;
    }
    void Update()
    {
        this.transform.Translate(0.0005f, 0, 0);
    }

}
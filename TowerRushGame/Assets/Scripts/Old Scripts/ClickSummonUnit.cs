using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSummonUnit : MonoBehaviour
{
    public GameObject Unit;
    public GameObject PlayerSpawn;
    //public GameObject PlayerClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {

        /*Vector3 position = transform.position;
        position.x = 0;
        position.y = 0;
        position.z = 0;*/

        GameObject playerClick = Instantiate(Unit, PlayerSpawn.transform.position , Quaternion.identity);
        //playerClick.transform.SetParent(PlayerSpawn.trasnform, false);
    }
}

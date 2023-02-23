using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAttack : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        if ((other.gameObject.tag.Equals("enemy")))
        {
            if (this.tag.Equals("player"))
            {
                if (this.GetComponent<UnitMovement>().warrior_class.Equals("Archer"))
                {
                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = true;
                    this.GetComponent<UnitMovement>().isStanding = false;
                    //this.gameObject.transform.GetChild(0).GetComponent<Animator>().SetTrigger("LoopAll");
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Shot");
                }
                else
                {
                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = true;
                    this.GetComponent<UnitMovement>().isStanding = false;
                    //this.gameObject.transform.GetChild(0).GetComponent<Animator>().SetTrigger("LoopAll");
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Attack1H");
                }

            }
            if (this.tag.Equals("enemy") && this.GetComponent<UnitMovement>().isFighting == false)
            {

                if (!other.gameObject.GetComponent<UnitMovement>().isFighting && !other.gameObject.GetComponent<UnitMovement>().isStanding)
                {


                }
                else if (other.gameObject.GetComponent<UnitMovement>().isFighting && !other.gameObject.GetComponent<UnitMovement>().isStanding)
                {

                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = false;
                    this.GetComponent<UnitMovement>().isStanding = true;
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Stand");

                }
                else if (!other.gameObject.GetComponent<UnitMovement>().isFighting && other.gameObject.GetComponent<UnitMovement>().isStanding)
                {

                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = false;
                    this.GetComponent<UnitMovement>().isStanding = true;
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Stand");

                }
                else { }

            }

        }
        if ((other.gameObject.tag.Equals("player")))
        {
            if (this.tag.Equals("player") && this.GetComponent<UnitMovement>().isFighting == false)
            {

                if (!other.gameObject.GetComponent<UnitMovement>().isFighting && !other.gameObject.GetComponent<UnitMovement>().isStanding)
                {

                }
                else if (other.gameObject.GetComponent<UnitMovement>().isFighting && !other.gameObject.GetComponent<UnitMovement>().isStanding)
                {
                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = false;
                    this.GetComponent<UnitMovement>().isStanding = true;
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Stand");
                }
                else if (!other.gameObject.GetComponent<UnitMovement>().isFighting && other.gameObject.GetComponent<UnitMovement>().isStanding)
                {
                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = false;
                    this.GetComponent<UnitMovement>().isStanding = true;
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Stand");
                }
                else { }

            }
            if (this.tag.Equals("enemy"))
            {
                if (this.GetComponent<UnitMovement>().warrior_class.Equals("Archer"))
                {
                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = true;
                    this.GetComponent<UnitMovement>().isStanding = false;
                    //this.gameObject.transform.GetChild(0).GetComponent<Animator>().SetTrigger("LoopAll");
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Shot");
                }
                else
                {
                    this.GetComponent<UnitMovement>().enabled = false;
                    this.GetComponent<UnitMovement>().isFighting = true;
                    this.GetComponent<UnitMovement>().isStanding = false;
                    //this.gameObject.transform.GetChild(0).GetComponent<Animator>().SetTrigger("LoopAll");
                    //this.transform.GetChild(0).GetComponent<Animator>().Play("Attack1H");
                }
            }

        }
    }
}

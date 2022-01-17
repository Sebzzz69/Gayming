using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPick : MonoBehaviour
{
    public Transform equipPostition;
    public float distance = 10f;
    GameObject currentWeapon;
    GameObject wp;

    bool canGrab;

    private void Update()
    {
        CheckWeapons();

        if (canGrab)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (currentWeapon != null)
                    Drop();

                Pickup();
            }
        }

        if(currentWeapon != null)
        {
            if (Input.GetKeyDown(KeyCode.Q))
                Drop();
        }

    }


    //Checks if weapon is grabbable or not 
    private void CheckWeapons()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "CanGrab")
            {
                Debug.Log("I Can Grab it!");
                canGrab = true;
                wp = hit.transform.gameObject;
            }
            else
                canGrab = false;
        }

    } 


    //Pickup function
    private void Pickup()
    {
        currentWeapon.transform.position = equipPostition.position;
        currentWeapon.transform.parent = equipPostition;
        currentWeapon.transform.localEulerAngles = new Vector3(0f, 180f, 0f);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;

    }
     

    //Drop funtion
    private void Drop()
    {
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false; 

    }

}//class




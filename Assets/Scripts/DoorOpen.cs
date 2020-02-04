using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public float Distance;
    public GameObject objActionDisplay;
    public GameObject objText;
    public GameObject door;
    public GameObject CrossExtra;
    
    public AudioSource doorsound;
    
    

// Update is called once per frame
    void Update()
    {
        Distance = CastingPlayer.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (Distance <= 1.0f)
        {
            CrossExtra.SetActive(true);
            objActionDisplay.SetActive(true);
            objText.SetActive(true);
        }
        else
        {
            CrossExtra.SetActive(false);
            objActionDisplay.SetActive(false);
            objText.SetActive(false);
        }
        if(Input.GetButtonDown("Action"))
        {
            if (Distance <= 2.0f)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                objActionDisplay.SetActive(false);
                objText.SetActive(false);
                door.GetComponent<Animation>().Play("AbrirPuerta");
                doorsound.Play();
            }
        }
    }

    void OnMouseExit()
    {
            CrossExtra.SetActive(false);
            objActionDisplay.SetActive(false);
            objText.SetActive(false);
        
    }
    
}

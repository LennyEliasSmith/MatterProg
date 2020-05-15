using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carIncident : MonoBehaviour
{
   public GameObject directionalLightObject;
   private Light directionalLight;
   Animator anim;

   public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        directionalLight = directionalLightObject.GetComponent<Light>();
        fire = GameObject.FindGameObjectWithTag("Fire");
        fire.SetActive(false);
    }

    //Car Accident Script
    public void CarAccident()
    {

        anim.SetBool("isCarActivated", true);
        Debug.Log("activated");

    }

    public void CarAccidentAftermath()
    {
        Debug.Log("it crashed");
        fire.SetActive(true);
        Debug.Log(fire);
        directionalLight.color = Color.red;
       

        
    }
}

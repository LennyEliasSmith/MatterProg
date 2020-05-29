﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debrisIncident : MonoBehaviour
{

    public GameObject directionalLightObject;
    private Light directionalLight;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        directionalLight = directionalLightObject.GetComponent<Light>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DebrisAccident()
    {
        anim.SetBool("isDebrisActivated", true);
        Debug.Log("activated");
        directionalLight.color = Color.red;


    }
}

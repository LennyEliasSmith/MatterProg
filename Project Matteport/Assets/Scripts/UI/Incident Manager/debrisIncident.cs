﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debrisIncident : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
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


    }
}

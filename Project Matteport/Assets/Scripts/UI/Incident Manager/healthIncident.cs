using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthIncident : MonoBehaviour
{

    public GameObject directionalLightObject;
    private Light directionalLight;
    Animator anim;
    public GameObject blood;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        directionalLight = directionalLightObject.GetComponent<Light>();
        blood = GameObject.FindGameObjectWithTag("blood");
        blood.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HealthIncident()
    {

        anim.SetBool("isHealthIncidentActive", true);
        Debug.Log("activated");

    }

    public void HealthIncidentAftermath()
    {
        Debug.Log("they are adead");
        directionalLight.color = Color.red;
        blood.SetActive(true);
        Debug.Log(blood);
        


    }

}

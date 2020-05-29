using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grillFireIncident : MonoBehaviour
{

    public GameObject directionalLightObject;
    private Light directionalLight;
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        directionalLight = directionalLightObject.GetComponent<Light>();
        fire = GameObject.FindGameObjectWithTag("Fire2");
        fire.SetActive(false);
    }

    // Update is called once per frame


    public void GrillFireAftermath()
    {
        Debug.Log("Fire burning in grill");
        fire.SetActive(true);
        Debug.Log(fire);
        directionalLight.color = Color.red;



    }
}

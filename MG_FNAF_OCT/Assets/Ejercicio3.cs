using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public GameObject myLight;
    private bool ison = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SwitchLight();
    }

    void SwitchLight()
    {
        if(Input.GetKeyUp(KeyCode.F)) { 
        if(ison)
            {
                myLight.GetComponent<Light>().enabled = false;      
                ison = false;

            }
            else
            {
                myLight.GetComponent<Light>().enabled = true;
                ison = true;
            }
        
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonComponent : MonoBehaviour
{
    public Material materialOff, materialOn, materialDisabled;
    public UnityEvent OnActived, OnDesactived;
   private bool buttonState;
    private MeshRenderer meshRenderer;
 
    // Start is called before the first frame update
    void Start()
    {
        buttonState = false;
        meshRenderer = GetComponent<MeshRenderer>();

        meshRenderer.material = materialOff;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Switch() {
        if (buttonState)
        {
            buttonState = false;
            meshRenderer.material = materialOff;
            OnDesactived.Invoke();
        }
        else
        {
            buttonState = true;
            meshRenderer.material = materialOn;
            OnActived.Invoke();
        }

    }
}

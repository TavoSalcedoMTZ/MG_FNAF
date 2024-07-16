using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonComponent : MonoBehaviour
{
    // Variables Publicas
    public Material materialOff, materialOn, materialDisabled;
    public UnityEvent OnActivated, OnDeactivated;


    // Variables Privadas
    private bool buttonState;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de variables
        buttonState = false;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materialOff;

    }

    public void Switch()
    {
        // Si el boton esta encendido
        if (buttonState)
        {
            // Lo apagamos
            buttonState = false;
            meshRenderer.material = materialOff;
            OnDeactivated.Invoke();
        }
        // Si el boton esta encendido
        else
        {
            // Lo encendemos
            buttonState = true;
            meshRenderer.material = materialOn;
            OnActivated.Invoke();
        }
    }
}
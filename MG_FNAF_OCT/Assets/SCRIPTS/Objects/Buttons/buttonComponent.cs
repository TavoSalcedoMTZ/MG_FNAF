using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonComponent : MonoBehaviour
{
    // Variables p�blicas para los materiales y eventos
    public Material materialOff;
    public Material materialOn;
    public Material materialDisabled;
    public UnityEvent OnActivated;
    public UnityEvent OnDeactivated;

    // Variables privadas
    private bool buttonState;
    private MeshRenderer meshRenderer;

    // Inicializaci�n
    void Start()
    {
        buttonState = false;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materialOff;
    }

    // M�todo para cambiar el estado del bot�n
    public void Switch()
    {
        if (!buttonState)
        {
            buttonState = true;
            meshRenderer.material = materialOn;
            OnActivated.Invoke();
        }
        else
        {
            buttonState = false;
            meshRenderer.material = materialOff;
            OnDeactivated.Invoke();
        }
    }

    // M�todo para desactivar el bot�n (cambia al materialDisabled)
    public void DisableButton()
    {
        buttonState = false;
        meshRenderer.material = materialDisabled;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonComponent : MonoBehaviour
{
    // Variables públicas para los materiales y eventos
    public Material materialOff;
    public Material materialOn;
    public Material materialDisabled;
    public UnityEvent OnActivated;
    public UnityEvent OnDeactivated;

    // Variables privadas
    private bool buttonState;
    private MeshRenderer meshRenderer;

    // Inicialización
    void Start()
    {
        buttonState = false;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materialOff;
    }

    // Método para cambiar el estado del botón
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

    // Método para desactivar el botón (cambia al materialDisabled)
    public void DisableButton()
    {
        buttonState = false;
        meshRenderer.material = materialDisabled;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    // Variables públicas
    public UnityEvent OnInteract;

    // Función de interacción
    public void Interact()
    {
        // Activar evento
        if (OnInteract != null)
        {
            OnInteract.Invoke();
        }
    }
}

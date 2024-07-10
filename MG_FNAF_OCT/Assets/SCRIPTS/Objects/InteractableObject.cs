using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    // Variables p�blicas
    public UnityEvent OnInteract;

    // Funci�n de interacci�n
    public void Interact()
    {
        // Activar evento
        if (OnInteract != null)
        {
            OnInteract.Invoke();
        }
    }
}

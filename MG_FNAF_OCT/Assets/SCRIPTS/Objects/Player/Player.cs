using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CameraMovement cameraMovement; // Corrige el nombre de la variable para mantener consistencia
    private Interactor interactor;

    void Start()
    {
        cameraMovement = GetComponent<CameraMovement>();
        interactor = GetComponent<Interactor>();

        // Verifica si los componentes necesarios están presentes
        if (cameraMovement == null)
        {
            Debug.LogError("CameraMovement component is missing from the player.");
        }

        if (interactor == null)
        {
            Debug.LogError("Interactor component is missing from the player.");
        }
    }

    void Update()
    {
        if (cameraMovement != null)
        {
            cameraMovement.CameraRotation();
        }

        if (interactor != null)
        {
            interactor.Interaction();
        }
    }
}

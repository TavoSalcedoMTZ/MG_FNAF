using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Variables p�blicas
    public float rotationSpeed = 100f;
    public float yMinRotation = -60f;
    public float yMaxRotation = 60f;

    // Variables privadas
    private float yRotation;

    // Update se llama una vez por frame
    void Update()
    {
        CameraRotation();
    }

    // Funci�n para mover la c�mara
    public void CameraRotation()
    {
        // Verificamos si el cursor est� en alguno de los bordes de la pantalla
        // Derecha
        if (Input.mousePosition.x >= Screen.width * 0.95f)
        {
            yRotation += rotationSpeed * Time.deltaTime;
        }
        // Izquierda
        else if (Input.mousePosition.x <= Screen.width * 0.05f)
        {
            yRotation -= rotationSpeed * Time.deltaTime;
        }

        // Aplicamos el �ngulo de rotaci�n
        yRotation = Mathf.Clamp(yRotation, yMinRotation, yMaxRotation);
        transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}

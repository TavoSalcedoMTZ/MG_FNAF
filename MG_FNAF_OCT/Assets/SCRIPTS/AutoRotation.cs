using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    // Variables Publicas
    public float rotationLimit, rotationSpeed;

    // Variables Privadas
    private float originalYrotation, yRotation;
    private int orientation;

    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de variables 
        originalYrotation = transform.localEulerAngles.y;
        yRotation = transform.localEulerAngles.y;
        orientation = 1;

    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    // Funcion para rotar
    void Rotation()
    {
        if ((transform.localEulerAngles.y <= originalYrotation - rotationLimit) || (transform.localEulerAngles.y >= originalYrotation + rotationLimit))
        {

        }


        yRotation = rotationSpeed * orientation * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, yRotation, transform.localEulerAngles.z);

    }

    // Funcion para cambiar la orientacion
    void ChangeRotation()
    {
        orientation *= -1;
    }
}

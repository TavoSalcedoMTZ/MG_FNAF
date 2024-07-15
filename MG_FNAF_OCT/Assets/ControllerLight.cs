using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLight : MonoBehaviour
{
    [SerializeField] private GameObject directionalLight; // Referencia al GameObject de la luz direccional
    [SerializeField] private bool isLightOn; // Estado de la luz

    void Start()
    {
        // Asegúrate de que el estado inicial de la luz coincida con el valor de isLightOn
        if (directionalLight != null)
        {
            directionalLight.SetActive(isLightOn);
        }
    }

    // Método para alternar el estado de la luz direccional
    public void ToggleLight()
    {
        isLightOn = !isLightOn; // Alterna el estado de isLightOn
        if (directionalLight != null)
        {
            directionalLight.SetActive(isLightOn); // Activa o desactiva la luz direccional
        }
    }
}
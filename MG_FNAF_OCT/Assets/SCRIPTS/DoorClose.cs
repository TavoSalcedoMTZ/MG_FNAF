using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private bool isOpen;

    void Start()
    {
        anim = GetComponent<Animator>();
        // Aseg�rate de que el estado inicial de la animaci�n coincida con el valor de isOpen
        anim.SetBool("IsOpen", isOpen);
    }

    // M�todo para alternar el estado de la puerta
    public void ToggleDoor()
    {
        isOpen = !isOpen; // Alterna el estado de isOpen
        anim.SetBool("IsOpen", isOpen); // Actualiza la animaci�n
    }
}

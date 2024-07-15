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
        // Asegúrate de que el estado inicial de la animación coincida con el valor de isOpen
        anim.SetBool("IsOpen", isOpen);
    }

    // Método para alternar el estado de la puerta
    public void ToggleDoor()
    {
        isOpen = !isOpen; // Alterna el estado de isOpen
        anim.SetBool("IsOpen", isOpen); // Actualiza la animación
    }
}

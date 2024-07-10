using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    [SerializeField] private Animator Anim;
    [SerializeField] private bool IsOpen;
    void Start()
    {
        Anim=GetComponent<Animator>();
    }

    void Update()
    {
        Anim.SetBool("IsOpen", IsOpen);
    }
}

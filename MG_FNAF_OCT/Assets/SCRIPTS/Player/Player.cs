using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CameraMovement cameraMovement;
    private Interactor interactor;
    void Start()
    {
        cameraMovement=GetComponent<CameraMovement>();
        interactor=GetComponent<Interactor>();
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraMovement.CameraRotation();
        interactor.Interaction();
        
    }
}

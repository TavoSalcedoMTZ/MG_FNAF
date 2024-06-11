using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public Transform cube;
    public float rotationSpeed;
    private float yRotate;
    void Start()
    {
        yRotate = 0;
        cube.rotation = Quaternion.Euler(45f, 0f, 45f);
    }

    // Update is called once per frame
    void Update()
    {
        RotateObject(cube);
        Camera.main.transform.LookAt(cube);
    }

    void RotateObject(Transform _object)
    {
       // _object.Rotate(new Vector3(0f, rotationSpeed * Time.deltaTime, 0f), Space.World); } 
   
        yRotate +=  rotationSpeed   *   Time.deltaTime;
        _object.rotation = Quaternion.Euler(new Vector3(_object.rotation.eulerAngles.x, yRotate, _object.rotation.eulerAngles.z));
    }
}

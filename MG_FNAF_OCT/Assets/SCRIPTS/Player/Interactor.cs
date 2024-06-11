using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
   public void Interaction()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit _hit;

            if (Physics.Raycast(ray, out _hit, 100))
            {
                if (_hit.transform.gameObject.GetComponent<InteractableObject>() != null)
                {
                    _hit.transform.gameObject.GetComponent<InteractableObjec>().Interact();

                }
            }
        }
    }
}

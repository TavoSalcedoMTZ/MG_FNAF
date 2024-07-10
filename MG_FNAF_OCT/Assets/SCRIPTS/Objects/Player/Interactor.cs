using UnityEngine;

public class Interactor : MonoBehaviour
{
    void Update()
    {
        Interaction();
    }

    public void Interaction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                // Intenta obtener el componente InteractableObject del objeto golpeado
                InteractableObject interactableObject = hit.transform.gameObject.GetComponent<InteractableObject>();

                // Si se encuentra el componente InteractableObject, llama a su método Interact
                if (interactableObject != null)
                {
                    interactableObject.Interact();
                }
            }
        }
    }
}

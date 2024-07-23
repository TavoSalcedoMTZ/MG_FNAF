using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatronic : MonoBehaviour
{
    // Varaibles publicas
    public float timeToMove, probabilityOfMoving;
    public Transform[] positions;
    public DoorClose door;

    public GameObject jumpscareMesh;

    // Variables privadas
    private int positionIndex;

    // Start is called before the first frame update
    void Start()
    {
        positionIndex = 0;
        StartCoroutine(MovementCoroutine(Random.Range(timeToMove -5f, timeToMove + 5f)));
    }

    // Funcion de Movimiento
    void Move()
    {
        if (Random.Range(0f, 100f) <= probabilityOfMoving)
        {
            // Verificamos si estamos en la puerta
            if (positionIndex == positions.Length -1)
            {
                if (door == null || door.IsOpen())
                {
                    StopAllCoroutines();
                    Attack();
                    return;
                }
                else
                {
                    positionIndex = 0;
                    transform.position = positions[positionIndex].position;
                    transform.rotation = positions[positionIndex].rotation;
                }
            }
            else
            {
                positionIndex++;
                transform.position = positions[positionIndex].position;
                transform.rotation = positions[positionIndex].rotation;
            }
        }
        StartCoroutine(MovementCoroutine(Random.Range(timeToMove - 5f, timeToMove + 5f)));
    }

    // Funcion para Atacar
    public void Attack()
    {
        jumpscareMesh.SetActive(true);
        LevelManager.Instance.PlayerDead();
    }

    // Corrutina de movimiento
    IEnumerator MovementCoroutine(float _time)
    {
        yield return new WaitForSeconds(_time);

        Move();
    }

}

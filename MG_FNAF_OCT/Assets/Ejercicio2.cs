using NUnit.Framework.Internal.Execution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    [SerializeField] private int firstn, lastn, loop;

    void Start()
    {
        switch(loop)
        {
            case 1:
                UsingForLoop();
                break;

           case 2:
                UsingWhileLoop();
                break;
          
           case 3:
                StartCoroutine(OnePerSecond());
                break;
           case 4:
                StartCoroutine(OnePerFrame());
                break;

            default:
                Debug.Log("Seleccion Erronea");
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    void UsingForLoop()
    {
        for (int i = firstn; i < lastn; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstn, lastn, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
            
        }
        Debug.Log("Terminando con ciclo for");
    }
    IEnumerator OnePerSecond()
    {
        for (int i = firstn; i < lastn; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstn, lastn, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
            yield return new WaitForSeconds(1f);
           
        }
        Debug.Log("Terminando ciclo por segundo");

    }
    IEnumerator OnePerFrame()
    {
        for (int i = firstn; i < lastn; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstn, lastn, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
            yield return null;

        }
        Debug.Log("Terminando ciclo por frame");

    }
    void UsingWhileLoop()
        {
            int _index = firstn;

            while(_index < lastn)
            {
                Debug.Log(_index);
                if(_index==(int)Mathf.Lerp(firstn,lastn,0.5f))
                {
                    Debug.Log("Mitad De Camino");
                }
                _index++;
            }
            Debug.Log("Se termino el while");
        }
    }
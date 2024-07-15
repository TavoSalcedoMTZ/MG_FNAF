using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercici1 : MonoBehaviour
{
    
    public float n1, n2;
    public float[] num;
    private float[] pnum;

    void Start()
    {
        Debug.Log("Numero 1: " + n1 + " Numero 2: " + n2);
        Debug.Log("Suma : " + add(n1, n2));
        Debug.Log("Multiplicacion : " + madd(n1, n2));
        Debug.Log("La sumatoria del arreglo publica es " + summation(num));
        Debug.Log("La sumatoria del arreglo privado es " + summation(pnum));

        pnum = new float[4] { 1f, 2f, 4f, 3f };

    }

    float add(float _n1, float _n2)
    {
        return _n1 + _n2;
    }

    float madd(float _n1, float _n2)

    {
        return (_n1 * _n2);
    }

    float summation(float[] _array)
    {
        float _summation = 0f;

        for (int i = 0; i < _array.Length; i++)
        {
            _summation += _array[i];

        }
        /*
        foreach(float _num in _array){
            _summation *= _num;
        }
         */
        return _summation;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ejercicio5 : MonoBehaviour
{
    public UnityEvent onAppear;
    [SerializeField] private float timetobegin;
    [SerializeField] private GameObject cube;
    void Start()
    {
        StartCoroutine(Begin());
    }

    IEnumerator Begin()
    {
        Debug.Log("Empezando en " + timetobegin + " segundos");
        yield return new WaitForSeconds(timetobegin);
        StartCoroutine(Appear());
    }
    IEnumerator Appear()
    {
        for (float _alpha = 0f; _alpha <= 1f; _alpha += 1f * Time.deltaTime)
        {
            Color _c = cube.GetComponent<Renderer>().material.color;
            _c.a = _alpha;
            cube.GetComponent<Renderer>().material.color = _c;
            yield return null;
        }
        onAppear.Invoke();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    // Variables Publicas
    public GameObject camerasPanel;
    public GameObject[] cameras;

    public AudioSource monitorAS, buttonAS;

    // Variables Privadas
    private int currentCamera;

    // Singleton
    public static Monitor Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de varibles
        currentCamera = 0;
    }

    // Funcion para activar la camara
    public void EnableCamera(int _index)
    {
        // Desactivamos la camera actual y activamos la nueva camara
        cameras[currentCamera].SetActive(false);
        cameras[_index].SetActive(true);
        currentCamera = _index;
        buttonAS.Play();

        /* Si la camara es donde esta la musicbox, activamos su UI
        if (currentCamera == 3)
        {
            MusicBox.Instance.SetStateUI(true);
        }
        else
        {
            MusicBox.Instance.SetStateUI(false);
        }
        */
    }

    // Funcion para cambiar el estado del monitor
    public void SetIsActive(bool _state)
    {
        cameras[currentCamera].SetActive(_state);
        camerasPanel.SetActive(_state);
        if (_state)
        {
            monitorAS.Play();
            EnergyManager.Instance.IncreaseConsumptionLevel();
        }
        else
        {
            monitorAS.Stop();
            EnergyManager.Instance.DecreaseConsumptionLevel();
        }

        /* MusicBox
        if (currentCamera == 3)
        {
            MusicBox.Instance.SetStateUI(_state);
        }
        */

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MusicBox : MonoBehaviour
{
    // Variables publicas 
    public UnityEvent OnOpened, OnWindUp;
    public GameObject musicboxPanel, warningIcon;
    public Image fillerImage;

    // Varibles privadas
    [SerializeField] private float fill, windUpCooldownTime, fillPerWindUp, consumptionRate, warningLevel;
    private bool isActive, isOpen, canWindUp;

    // Singleton
    public static MusicBox Instance { get; private set; }

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
        // inicializacion de Variables
        fill = 1f;
        canWindUp = true;
        isOpen = false;
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (musicboxPanel.activeSelf)
        {
            UpdateUI();
        }

        if (isActive && !isOpen)
        {
            Consumption();
        }

    }
    
    // Funcion de consumo
    public void Consumption()
    {
        fill -= consumptionRate * Time.deltaTime;
        
        // Advertencia
        if (fill <= warningLevel)
        {
            warningIcon.SetActive(true);
        }
        else
        {
            warningIcon.SetActive(false);
        }

        if (fill <= 0f)
        {
            warningIcon.SetActive(false);
            isOpen = true;
            OnOpened.Invoke();
        }

    }

    // Funcion para activar o desactivar la UI
    public void SetStateUI(bool _state)
    {
        musicboxPanel.SetActive(_state);
    }

    // Funcion para actualizar la UI
    public void UpdateUI()
    {
        fillerImage.fillAmount = fill;
    }

    // Funcion para activar o desactivar la caja de musica
    public void SetIsActive(bool _state)
    {
        isActive = _state;
    }

    // Funcion para darle cuerda a la caja
    public void WindUpMusicBox()
    {
        if (isActive && !isOpen)
        {
            if (canWindUp)
            {
                fill += fillPerWindUp;
                fill = Mathf.Clamp(fill, 0f, 1f);
                OnWindUp.Invoke();
                StartCoroutine(ButtonCooldown());
            }
        }
    }

    // Corrutina para el cooldown del boton
    IEnumerator ButtonCooldown()
    {
        canWindUp = false;
        yield return new WaitForSeconds(windUpCooldownTime);
        canWindUp = true;
    }

}

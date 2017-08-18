using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ControlFlechas : MonoBehaviour
{
    public bool Pasar = true;
    public GameObject Parte1;
    public GameObject Parte2;

    public void Start()
    {        
    }
    public void Siguiente()
    {
        if (Pasar)
        {
            Parte1.SetActive(false);
            Parte2.SetActive(true);
            Pasar = false;
        }
    }
    public void Atras()
    {
        if (!Pasar)
        {
            Parte1.SetActive(true);
            Parte2.SetActive(false);
            Pasar = true;
        }
    }
    public void Comprar()
    {
        InfoCompra info = EventSystem.current.currentSelectedGameObject.AddComponent<InfoCompra>();
        info.Mejorar();
    }
    public void Salir()
    {
        SceneManager.LoadScene(2);
    }
}

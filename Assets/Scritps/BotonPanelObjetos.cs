using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPanelObjetos : MonoBehaviour
{
    public GameObject panel;
    public GameObject btn_mostrar;

    void Start() {
        panel = GameObject.Find("Contenedor_panel");
        btn_mostrar = GameObject.Find("Button_mostrar_panel");
        panel.SetActive(false);

    }

    public void cerrarPanel() {
        panel.SetActive(false);
        btn_mostrar.SetActive(true);
    }

    public void mostrarPanel()
    {
        panel.SetActive(true);
        btn_mostrar.SetActive(false);
    }
}

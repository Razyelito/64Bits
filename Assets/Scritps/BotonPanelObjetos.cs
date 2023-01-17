using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPanelObjetos : MonoBehaviour
{
    public GameObject panel;
    public GameObject btn_mostrar;
    public GameObject mensaje;
    public static bool esPrimeraVez = true;
    public static bool activoMensaje = true;

    void Start() {
        panel = GameObject.Find("Contenedor_panel");
        btn_mostrar = GameObject.Find("Button_mostrar_panel");
        mensaje = GameObject.Find("Contenedor_mensaje");
        panel.SetActive(false);
        mensaje.SetActive(false);

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.P) && activoMensaje) {
            panel.SetActive(true);
            btn_mostrar.SetActive(false);
            activoMensaje = false;
        }
        else if (Input.GetKeyDown(KeyCode.P) && !activoMensaje)
        {
            panel.SetActive(false);
            btn_mostrar.SetActive(true);
            activoMensaje = true;
            if (!esPrimeraVez) {
                mensaje.SetActive(false);
            }
        }
    }

    public void cerrarPanel() {
        panel.SetActive(false);
        btn_mostrar.SetActive(true);
        if (activoMensaje) {
            mensaje.SetActive(false);
        }
    }

    public void mostrarPanel()
    {
        panel.SetActive(true);
        btn_mostrar.SetActive(false);
        if (esPrimeraVez) {
            mensaje.SetActive(true);
            esPrimeraVez = false;
        }
        
    }
}

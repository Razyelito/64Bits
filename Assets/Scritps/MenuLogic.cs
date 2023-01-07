using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void irWorld() 
    {
        SceneManager.LoadScene("World");
    }

    public void salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}

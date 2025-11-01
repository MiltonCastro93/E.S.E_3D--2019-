using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void empezar()
    {
        SceneManager.LoadScene("Nivel");
    }

    public void cerrar()
    {
        Application.Quit();
    }

    public void volverMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}

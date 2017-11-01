using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonContinuar : MonoBehaviour {

    public void CargarJuego()
    {
        // Debug.Log("Click");
        SceneManager.LoadScene("Nivel1");

    }
}
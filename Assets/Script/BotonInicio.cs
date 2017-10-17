using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonInicio : MonoBehaviour {


    public void CargarMenu()
    {
        //Debug.Log("Click");
        SceneManager.LoadScene("Menu");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioJuego : MonoBehaviour {

    public float tiempoInicio;
    public float tiempoEspera;        
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        tiempoInicio += Time.deltaTime;
        if (tiempoInicio >= tiempoEspera)
        {
            SceneManager.LoadScene("Menu");
        }
           
    }
}

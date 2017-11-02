using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour {
    public static int vidas = 5;
    public static int oro;

    public Text textoVidas;
    public Text textoOro;

    void Update() {
        textoVidas.text = vidas.ToString();
        textoOro.text = oro.ToString();

        if (vidas <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

}

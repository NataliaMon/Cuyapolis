using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meta : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("unidad"))
        {
            Jugador.vidas -= 1;
            GetComponent<AudioSource>().Play();
        }
    }

    

}

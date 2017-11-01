using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meta : MonoBehaviour {

    public int ferret = 0;
    public Text textoVidas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("unidad"))
        {
            ferret +=1;
            textoVidas.text = (5 - ferret).ToString();
            GetComponent<AudioSource>().Play();
            
            if (ferret == 5)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    

}

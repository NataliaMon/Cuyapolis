using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour {

    public int ferret = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("unidad"))
        {
            ferret +=1;
            GetComponent<AudioSource>().Play();
            
            if (ferret == 5)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    

}

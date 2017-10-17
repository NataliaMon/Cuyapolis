using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidad : MonoBehaviour {

    public GameObject ruta;
    private int indice;
    private Vector3 posicion_original;
    private Vector3 posicion_siguiente;
    public float vel = 1;
    private float distancia_punto = 0.1f;
    public int vida;
    Animator animator;
  

    // Use this for initialization
    void Start() {
        posicion_original = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0).position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = posicion_siguiente - transform.position;
        transform.position += dir.normalized * vel * Time.deltaTime;

        if (dir.magnitude <= distancia_punto)
        {
            if (indice + 1 < ruta.transform.childCount)
            {
                indice++;
                posicion_siguiente = ruta.transform.GetChild(indice).position;
                //Debug.Log("xs"+posicion_siguiente.x+"ys"+posicion_siguiente.y);
            }
            else
            {
                indice = 0;
                this.transform.position = posicion_original;
                posicion_siguiente = ruta.transform.GetChild(0).position;
            }
            // Asigno los parametros del animator segun los signos de los componentes del vector hacia el siguiente nodo
            animator.SetFloat("x", Mathf.Sign((posicion_siguiente - transform.position).x));
            animator.SetFloat("y", Mathf.Sign((posicion_siguiente - transform.position).y));
        }

        // Si la vida es igual a cero se destruye este gameobject unidad
        if (vida <= 0)
        {
            PoolingUnidades.unidades.Remove(transform.parent.gameObject);
            Destroy(transform.parent.gameObject);

        }

        

    }

   

}

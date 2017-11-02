using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonTorre : MonoBehaviour {

    public GameObject torreObject;

    private void OnMouseDown()
    {
        // Buscar el script torre
        Torre torre = torreObject.GetComponentInChildren<Torre>();

        // Verificar que tenemos suficiente oro para construir esta torre
        if (Jugador.oro >= torre.costoOro) {

            Instantiate(torreObject, transform.parent.position, Quaternion.identity);
            Destroy(transform.parent.gameObject);

            // Solo empezar a poner enemigos cuando haya por lo menos una torre
            FindObjectOfType<PoolingUnidades>().hayTorres = true;

            // Descontar el oro gastado
            Jugador.oro -= torre.costoOro;
        }

    }




}

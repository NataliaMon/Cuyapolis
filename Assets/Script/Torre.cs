using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

    public Proyectil proyectilprefab;
    public float cooldown = 1f;
    private float cooldownTimer = 0;
    private bool puededisparar = true;
    public Transform origenProyectil;


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("unidad") && puededisparar)
        {
            Debug.DrawLine(transform.position, other.transform.position, Color.green);

            // Obtener el angulo hacia el enemigo, desde el angulo inicial del proyectil; ver si el angulo es negativo o positivo
            float angle = Vector3.Angle(Vector3.right, other.transform.position - transform.position);
            angle *= Mathf.Sign((other.transform.position - transform.position).y);
            
            //Crear una nueva instancia (copia) del objeto proyectilprefab y meterla a la escena, en la posicion de origen de proyectil; dar rotacion en el angulo dado en el eje z
            Proyectil nuevoProyectil = Instantiate(proyectilprefab, origenProyectil.position, Quaternion.AngleAxis(angle, Vector3.forward));
            GetComponent<AudioSource>().Play();

            //Asignar el gameObject del enemigo al proyectil
            nuevoProyectil.objetivo = other.gameObject;

            puededisparar = false;
           
        }

        
    }

    private void Update()
    {
        if (cooldownTimer >= cooldown)
        {
            puededisparar = true;
            cooldownTimer = 0;
        }

        cooldownTimer += Time.deltaTime;
    }
}

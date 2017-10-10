using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraV : MonoBehaviour{
    public Scrollbar BarraVida;
    public float health = 100;

    public void Damage (float value)
    {
        health -= value;
        BarraVida.size = health / 100f;
    }
}
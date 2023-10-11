using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadEje : MonoBehaviour
{
    public float velocidad;
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");  // Valor entre -1 y 1
        float movimientoVertical = Input.GetAxis("Vertical"); // Valor entre -1 y 1

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha Arriba: " + (velocidad * movimientoVertical).ToString());
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha Abajo: " + (velocidad * movimientoVertical).ToString());
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha Izquierda: " + (velocidad * movimientoHorizontal).ToString());
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha Derecha: " + (velocidad * movimientoHorizontal).ToString());
        }
    }
}

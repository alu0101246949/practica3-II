using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Shoot"))
        {
            Disparar();
        }

    }

    void Disparar()
    {
        Debug.Log("¡Pum!");
    }
}

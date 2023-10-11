using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Mostrar en consola la etiqueta del objeto que colisionó con el cilindro
        Debug.Log(collision.gameObject.tag + " ha colisionado con el cilindro");
    }
}

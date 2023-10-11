using UnityEngine;

public class MoverCuboHaciaEsfera : MonoBehaviour
{
    public GameObject esfera; // Referencia al objeto esfera.
    public float speed = 2f; // Velocidad de movimiento del cubo.

    void Update()
    {
        // Vector que apunta desde el cubo a la esfera.
        Vector3 haciaEsfera = esfera.transform.position - transform.position;

        // Conservamos la altura actual del cubo.
        haciaEsfera.y = 0;

        // Normalizamos el vector para que su magnitud no afecte a la velocidad de movimiento.
        Vector3 direccion = haciaEsfera.normalized;

        // Movemos el cubo en la dirección de la esfera.
        transform.Translate(direccion * speed * Time.deltaTime, Space.World);
    }
}

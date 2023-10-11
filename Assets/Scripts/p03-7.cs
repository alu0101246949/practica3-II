using UnityEngine;

public class MoverYGirarCubo : MonoBehaviour
{
    public GameObject esfera;
    public float speed = 2f;

    void Update()
    {
        // Vector que apunta desde el cubo a la esfera.
        Vector3 haciaEsfera = esfera.transform.position - transform.position;
        
        // Mantener la altura del cubo constante.
        haciaEsfera.y = 0;

        // Normalizar el vector para que la velocidad no dependa de la distancia.
        Vector3 direccion = haciaEsfera.normalized;
        
        // Girar el cubo para que mire hacia la esfera.
        transform.LookAt(esfera.transform.position);
        
        // Mover el cubo hacia la esfera.
        transform.Translate(direccion * speed * Time.deltaTime, Space.World);
    }
}

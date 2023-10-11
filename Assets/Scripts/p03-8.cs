using UnityEngine;

public class MoverYGirarObjeto : MonoBehaviour
{
    public float speed = 2f;          // Velocidad de avance del objeto.
    public float rotationSpeed = 200f; // Velocidad de rotación del objeto.

    void Update()
    {
        // Obtener la entrada del eje horizontal.
        float girar = Input.GetAxis("Horizontal"); // A, D o flechas izquierda/derecha
        
        // Girar el objeto en base al input horizontal.
        transform.Rotate(0f, girar * rotationSpeed * Time.deltaTime, 0f, Space.World);
        
        // Mover el objeto siempre hacia adelante en su dirección local.
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);

        // Dibujar un rayo para depuración y visualizar la dirección hacia adelante del objeto.
        Debug.DrawRay(transform.position, transform.forward * 5f, Color.blue);
    }
}

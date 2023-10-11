using UnityEngine;

public class MoverCuboSinTeclas : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1f, 0f, 0f); // Dirección del movimiento
    public float speed = 2f; // Velocidad del movimiento

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}

using UnityEngine;

public class MoverEsfera : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        float movimientoHorizontal = 0f;
        float movimientoVertical = 0f;

        if (Input.GetKey(KeyCode.W)) { movimientoVertical = 1f; }
        if (Input.GetKey(KeyCode.S)) { movimientoVertical = -1f; }
        if (Input.GetKey(KeyCode.A)) { movimientoHorizontal = -1f; }
        if (Input.GetKey(KeyCode.D)) { movimientoHorizontal = 1f; }

        Vector3 moveDirection = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}

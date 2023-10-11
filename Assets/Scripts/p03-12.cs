using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ControlCilindro : MonoBehaviour
{
    public GameObject esfera;
    public float fuerza = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (esfera)
        {
            Vector3 direccion = (esfera.transform.position - transform.position).normalized;
            rb.AddForce(direccion * fuerza);
        }

        // Control manual con teclas (ejemplo: WASD)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movimiento * fuerza);
    }
}

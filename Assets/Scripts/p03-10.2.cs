using UnityEngine;

public class EsferaColision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag + " ha colisionado con la esfera");
    }
}

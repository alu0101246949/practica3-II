using UnityEngine;

public class CilindroTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag + " ha entrado en la zona del cilindro");
    }
}

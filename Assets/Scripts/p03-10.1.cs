using UnityEngine;

public class CuboColision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag + " ha entrado en la zona del cubo");
    }
}

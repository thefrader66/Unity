using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Boostpad : MonoBehaviour
{
    public float boostforce = 30f;
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.forward *  boostforce);
    }
}

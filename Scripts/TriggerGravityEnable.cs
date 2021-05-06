using UnityEngine;

public class OnTriggerEnable : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] PlayerFixedMove playerMovement;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Arena")
        {
            rigidBody.isKinematic = false;
            rigidBody.useGravity = true;
            playerMovement.enabled = false;
        }
    }
}

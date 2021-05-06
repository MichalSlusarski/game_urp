using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Plane")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

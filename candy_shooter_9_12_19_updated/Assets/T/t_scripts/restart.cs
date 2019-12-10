using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class restart : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("enm"))
            {
            SceneManager.LoadScene(0);
        }
    }
}

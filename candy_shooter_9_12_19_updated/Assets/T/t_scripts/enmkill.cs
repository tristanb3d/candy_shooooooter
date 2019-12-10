using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enmkill : MonoBehaviour
{
    void OnTriggerEnter(Collider colli)
    {
        if (colli.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
            Debug.Log("restart"); 
        }
    }
}
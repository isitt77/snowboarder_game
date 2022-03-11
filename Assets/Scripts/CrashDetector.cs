using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashReloadDelay = 1f;

   void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Debug.Log("You crashed!");
            Invoke("ReloadScene", crashReloadDelay);
        }   
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

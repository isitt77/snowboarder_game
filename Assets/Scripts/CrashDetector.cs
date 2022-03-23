using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashReloadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

   void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Debug.Log("You crashed!");
            CrashFX();
            FindObjectOfType<PlayerController>().DisableControls();
            
            Invoke("ReloadScene", crashReloadDelay);
        }   
    }

    public void CrashFX()
    {
        crashEffect.Play();
        GetComponent<AudioSource>().PlayOneShot(crashSFX);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

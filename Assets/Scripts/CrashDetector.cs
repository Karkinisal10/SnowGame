using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    
[SerializeField] ParticleSystem crashEffect;
//[SerializeField] AudioClip crashSFX;
    void OnTriggerEnter2D(Collider2D other) 
    {
        crashEffect.Play();
        if(other.tag == "Ground")
        {
            
            //GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

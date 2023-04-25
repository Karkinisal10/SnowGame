using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
[SerializeField]float loadDelay = 2;
[SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
      finishEffect.Play();
      if (other.tag == "Player")
      {
        finishEffect.Play();
        GetComponent<AudioSource>().Play();
       Invoke("ReloadScene", loadDelay);
      
      }
   }
   void ReloadScene()
   {
    SceneManager.LoadScene(0);
   }
}

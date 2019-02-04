using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnCollide : MonoBehaviour
{
    public AudioSource voSource;
    void Start () {
        voSource = GetComponent<AudioSource> ();
    }        
    
    private void Update() {
        
    }
    
    void OnTriggerEnter (Collider collide) {
         
        if (collide.gameObject.tag == "Player") {
            voSource.Play ();
            Destroy(gameObject);
        }
         
    }
}

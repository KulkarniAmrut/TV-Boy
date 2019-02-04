using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene("DeSc2");
        }
    }
}
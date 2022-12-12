using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die1 : MonoBehaviour
{
   void OnTriggerEnter (Collider hit)
{
    if (hit.gameObject.tag == "Enemy")
    {
         Scene scene = SceneManager.GetActiveScene();
                 SceneManager.LoadScene(scene.name);
    }
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint1 : MonoBehaviour
{
  public void LoadB(int sceneAnumber) {
  void OnTriggerEnter2D(Collider2D col)
  {
      if(gameObject.tag == "Player") {
          SceneManager.Loadscene(1)

      }
  }
  }

}

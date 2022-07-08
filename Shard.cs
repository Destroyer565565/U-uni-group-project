using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shard : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rgbd;
   public void LoadB(int sceneANumber);
   public float dir;
   public float speed;
   void OnTriggerEnter2D(Collider2D col) {

       if(col.gameObject.tag == "Player")
       {
           
           SceneManager.Loadscene(1);

       }
   }
   

   void Update() {
    rgbd.transform.Translate(dir * speed * Time.deltaTime, rgbd.velocity.y,0);
   }

   void OnCollisionEnter2D(Collision2D other) {
      dir = dir * -1;

   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shard : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rgbd;
 
   public float dir;
   public float speed;

   private void Move(float dir)
    {
        rgbd.transform.Translate(new Vector3(dir, rgbd.velocity.y,0));
    }
     

   void Update() {
    rgbd.transform.Translate(dir * speed * Time.deltaTime, rgbd.velocity.y,0);
   }

   void OnCollisionEnter2D(Collision2D other) {
      dir = dir * -1;

   }
}

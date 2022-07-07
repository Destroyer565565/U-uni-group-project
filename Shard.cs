using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shard : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rgbd;
   public float dir;
   public float speed;



   
   private void CheckMove(); {
       float dir =-1f
 Move(dir * Time.deltaTime * speed);
    
   }
   

   void Update() {
    rgbd.transform.Translate(dir * speed * Time.deltaTime, rgbd.velocity.y,0);

    CheckMove();
   }

   void OnCollisionEnter2D(Collision2D other) {
      dir = dir * -1;

   }
}

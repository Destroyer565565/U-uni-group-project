using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shard : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rgbd;
   public float dir;
   public float speed;



   
   private void CheckMove() {
       

       Move(dir * Time.deltaTime * speed);
    
   }
   

   private void Move(float dir)
    {
        rgbd.transform.Translate(new Vector3(dir, rgbd.velocity.y,0));
    }

   void OnCollisionEnter2D(Collision2D other) {
      dir = dir * -1;

   }
}

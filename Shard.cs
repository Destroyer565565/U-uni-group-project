using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rgbd;
   public float dir;
   public float speed;
   void OnTriggerEnter2D(Collider2D col) {

       if(col.gameObject.tag == "Main")
       {
           Destroy(this.gameObject);
       }
   }
   

   void Update() {
    rgbd.transform.Translate(dir * speed * Time.deltaTime, rgbd.velocity.y,0);
   }

   void OnCollisionEnter2D(Collision2D other) {
      dir = dir * -1;

   }
}

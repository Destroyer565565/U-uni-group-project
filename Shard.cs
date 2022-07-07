using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rgbd;
   public float dir;
   public float speed;
  
   

   

   void OnCollisionEnter2D(Collision2D other) {
      dir = dir * -1;
   rgbd.transform.Translate(dir * speed * Time.deltaTime, rgbd.velocity.y,0);
   }
}

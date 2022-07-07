using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownmovement : MonoBehaviour
{
    // Start is called before the first frame update

   [SerializeField] private Rigidbody2D rgbd;

   [SerializeField] private AudioSource sfx;

    public float speed;  
    public GameObject Checkpoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMove(); // A and D

        UpdownM(); // W and S
    }

    private void CheckMove() // A and D
    {

        float dir = 0f;
        if(Input.GetKey(KeyCode.A))
        {
            dir = -1f;
        }
        if(Input.GetKey(KeyCode.D))
        {
            dir = 1f;
        }
        
        if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            dir = 0f;
        }
        
        Move(dir * Time.deltaTime * speed);

    }
    private void Move(float dir)
    {
        rgbd.transform.Translate(new Vector3(dir, rgbd.velocity.y,0));
    }
     
     private void UpdownM() // W and S
     {

         float UD = 0f; // Up and down
         if(Input.GetKey(KeyCode.W)) {
             UD = 1f;
         }
         if(Input.GetKey(KeyCode.S)) {
             UD = -1f;
         }
         if(!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            UD = 0f; 
        }
         WD(UD * Time.deltaTime * speed); // Up And down
        
     }
      
      private void WD(float UD)
      {
          rgbd.transform.Translate(new Vector3(rgbd.velocity.x, UD, 0));
      }
     
     private void OnCollisionEnter2D(Collision2D col) //When the player touches the red wall they die and reset
    {
         if(col.gameObject.tag == "RedWall") { 
        rgbd.transform = Checkpoint.transform.position;
     }
     


  }
void OnTriggerEnter2D(Collider2D col) {

            if(col.gameObject.tag == "Checkpoint1") {
          SceneManager.Loadscene(2);
            }
          }










}



 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame


    [SerializeField] private Rigidbody2D rgbd;

    [SerializeField] private AudioSource sfx;

    public float speed;
    public Vector2 jump;
   
   
    void Update()
    {
        
        Jump();

        CheckMove();
       
       
    }
    
    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.W))
     {
        rgbd.AddForce(jump, ForceMode2D.Impulse);
     }
        //rgbd.AddForce(new Vector2(), ForceMode2D.Impulse);
        
        //sfx.Play();
        
    }
    

    private void CheckMove()
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


    void OnCollisionEnter2D(Collision2D col) {


            if(col.gameObject.tag == "Finish") 
            { 
                Destroy(this.gameObject);
            }
             if(col.gameObject.tag == "Enemy") {
                Destroy(this.gameObject);
             }
        }

          void OnTriggerEnter2D(Collision2D col) {

            if(col.gameObject.tag == "Checkpoint1")
          SceneManager.Loadscene(2)
          }
}

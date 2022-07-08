// SceneB.
// SceneB is given the sceneBuildIndex of 0 which will
// load SceneA from the Build Settings

using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint1 : MonoBehaviour
{
 
    public void LoadB(int sceneANumber)
    {
         void OnTriggerEnter2D(Collider2D col)
        {
            
        
        if(col.gameObject.tag == "Player") {
        SceneManager.LoadScene(1);
        }
    }
}

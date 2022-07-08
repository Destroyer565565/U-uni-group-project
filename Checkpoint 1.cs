using UnityEngine;
using UnityEngine.SceneManagement;

public class  Checkpoint1 : MonoBehaviour
{
  
    public void LoadB(int sceneANumber)
    {
         void OncollsionEnter2D(Collision2D col)
        {
            
        
        if(col.gameObject.tag == "Player") {
        SceneManager.LoadScene(1);
        }
    }
}
}

// SceneB.
// SceneB is given the sceneBuildIndex of 0 which will
// load SceneA from the Build Settings

using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LoadSceneB");
    }

    public void LoadB(int sceneANumber)
    {
        if(gameObject.tag == "Player") {
        SceneManager.LoadScene(1);
        }
    }
}

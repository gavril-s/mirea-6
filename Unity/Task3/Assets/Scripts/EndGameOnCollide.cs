using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameOnCollide : MonoBehaviour
{
    public string endGameOnCollideTag;
    public string message;
    
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == endGameOnCollideTag) 
        {
            Debug.Log(message);
            quitGame();
        }
    }

    private void quitGame() 
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

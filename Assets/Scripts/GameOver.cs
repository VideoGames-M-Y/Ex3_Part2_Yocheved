using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour{
    [SerializeField] string sceneName = "GameOver"; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe")) 
        {
            Debug.Log("Collided with pipe, loading scene: " + sceneName);
            SceneManager.LoadScene(sceneName); 
        }
    }
}
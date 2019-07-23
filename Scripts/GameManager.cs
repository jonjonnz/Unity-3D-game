using UnityEngine;
using UnityEngine.SceneManagement; // Used when we need to change a scene or reload the current scene

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; // to make the if statement run only once

    public float restartDelay = 1f;

    public GameObject completeLevelUi ;
    

    public void EndGame() // added public so it can be accessed in another script using Find object
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
           // Restart(); // Call the restart function to reset the game
           Invoke("Restart", restartDelay);
        }
    }
    public void Completelevel()
    {
        completeLevelUi.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
    }

    void Restart()
    {
        //SceneManager.LoadScene("Level 1");
        // gonna have multiple scenes/levels so e can't use this
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    

}

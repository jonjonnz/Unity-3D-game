using UnityEngine;
using UnityEngine.SceneManagement;


public class GetNextLevel : MonoBehaviour
{
   public void loadNextScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}

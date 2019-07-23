using UnityEngine;
using UnityEngine.UI;  // To use UI components
public class Score : MonoBehaviour
{
    public Transform player; // For position of Player object
    public Text scoreText; //  Reference to UI text


    // Update is called once per frame
    void Update()
    {
        //scoreText.text = (player.position.z-10).ToString("0"); // Update the score on UI with player's "z" position and convert it to String
    }
}

using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement pm; // Creating a reference to Player movement script to disable it
    
    //inbuilt collison system
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.gameObject.tag == "Obstacle")  // using tag instead of name to make it easier
        {
            pm.enabled = false; // disable the player movement after collision
            FindObjectOfType<GameManager>().EndGame(); // using find object instead of creating reference because once the player object is deleted and made again(respawned) it wont work
        }
    }
}

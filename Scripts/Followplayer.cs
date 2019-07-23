using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Transform player; //  reference to position and other stuff of player object
    public Vector3 offset; // creating an offset so the camera doesnt become fps

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; // changing the camera position with the player position added by offset value
    }
}

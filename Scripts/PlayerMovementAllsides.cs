using UnityEngine;

public class PlayerMovementAllsides : MonoBehaviour
{
    public float movementforce = 600f;
    public Rigidbody rb;
   
    // FixedUpdate(for smoothness) is called once per frame
    void FixedUpdate()
    {
    
        //For user input movement
        if (Input.GetKey("d"))  // go right
        {
            rb.AddForce(movementforce * Time.deltaTime, 0, 0);  // Using Time.deltaTime to make it adjust to different framerates
        }
        if (Input.GetKey("a"))  // go left
        {
            rb.AddForce(-movementforce * Time.deltaTime, 0, 0);  // Using Time.deltaTime to make it adjust to different framerates
        }
        if (Input.GetKey("w"))  // go forward
        {
            rb.AddForce(0, 0, movementforce * Time.deltaTime);  // Using Time.deltaTime to make it adjust to different framerates
        }
        if (Input.GetKey("s"))  // go backward
        {
            rb.AddForce(0, 0, -movementforce * Time.deltaTime);  // Using Time.deltaTime to make it adjust to different framerates
        }
    }
}

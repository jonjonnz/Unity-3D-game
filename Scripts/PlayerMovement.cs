using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // Reference to Rigid body
    public float forwardforce = 1000f; // Variable speed of player
    public float sidewaysforce = 600f; // variable movement speed of player
 
    // Fixed(for smoothness) Update is called once per frame 
    void FixedUpdate()
    {
        

        rb.AddForce(0, 0, forwardforce * Time.deltaTime);   //Add a constant forward force

        //For user input movement
        if (Input.GetKey("d"))  // go right
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange); // Using Time.deltaTime to make it adjust to different framerates
        }
        if (Input.GetKey("a"))   // go left
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Using Time.deltaTime to make it adjust to different framerates
        }

        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2000; //Forward speed with a constant force
    public float sidespeed = 500;
    
    // Update is called once per frame
    //FixedUpdate for Unity Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidespeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidespeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < 0)
        {
            FindObjectOfType<Manager>().EndGame();
        }
    }
}

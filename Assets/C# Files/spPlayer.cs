using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 500;
    public float side = 200;



    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("Hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(0,0,forward*Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(side*Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a")){
            rb.AddForce(-side*Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w")){
            rb.AddForce(0,0,forward*Time.deltaTime , ForceMode.VelocityChange);
        }
        else if (Input.GetKey("x")){
            rb.AddForce(0 , 0 , -forward * Time.deltaTime , ForceMode.VelocityChange);
        }
        else if (Input.GetKey("escape"))
        {
            Application.Quit();
            Debug.Log("Goodbye");
        }
        if (rb.position.y < 22)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

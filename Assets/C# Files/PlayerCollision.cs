using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public spPlayer movement;
    //public GameManager gamemanager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "ground")
        {
            Debug.Log("your player hit the ground");
        }
        else if (collisionInfo.collider.tag == "Consequences")
        {
            Debug.Log("your player hit the " + collisionInfo.collider.name);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            //gamemanager.EndGame();
        }
    }
}

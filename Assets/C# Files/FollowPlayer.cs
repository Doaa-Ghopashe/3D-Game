using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offest;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offest;
        // Debug.Log(player.position);
    }
}

using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{

    float Horizontal = Input.GetAxis("Horizontal");
    float Vertical = Input.GetAxis("Vertical");

    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            Vector3 movement = new Vector3(Horizontal, Vertical, 0);
            transform.position = transform.position + movement;
        }
    }

    void Update()
    {
        HandleMovement();
    }
}

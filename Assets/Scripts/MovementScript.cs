using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    
    
    float speed = 1f;


    void Update()
    {
        GameObjectMovement();
    }

    private void GameObjectMovement()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}

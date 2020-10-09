using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObjectMovement();
    }

    private void GameObjectMovement()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}

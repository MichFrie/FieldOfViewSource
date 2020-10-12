using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float xRot, yRot, zRot;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("Sphere"))
        {
            xRot += 90;
            transform.eulerAngles = new Vector3(xRot, 0, 0);
            other.gameObject.SetActive(false);
        }
    }
}

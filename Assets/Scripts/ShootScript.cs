using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShootScript : MonoBehaviour
{
    public KeyCode shootkey = KeyCode.F;
    public GameObject projectile;
    private Vector3 target;
    private Vector3 directionVector;

    public float shootForce = 100.0f;
    void Start()
    {
        
    }

    void Update()
    {
        target = transform.GetComponentInChildren<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        directionVector = (target - transform.position).normalized;

        if (Input.GetKeyDown(shootkey))
        {
            GameObject shot = GameObject.Instantiate(projectile, transform.position, Quaternion.identity);
            shot.GetComponent<Rigidbody>().velocity = directionVector * shootForce;   
        }

    }
}

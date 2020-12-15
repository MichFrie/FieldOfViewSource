using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    float xRot = 90;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("Sphere")) 
        {
            other.gameObject.SetActive(false);
            //switch (xRot)
            //{
            //    case -1: xRot = -91; break;
            //    case -91: xRot = -181; break;
            //    case -181: xRot = -271; break;
            //    case -271: xRot = -1; break;
            //    default: Debug.Log(xRot); break;
            //}

            //transform.parent.eulerAngles = new Vector3(Mathf.Abs(xRot), 0, 0);
            transform.parent.Rotate(Vector3.right, xRot);
        }
    }
}

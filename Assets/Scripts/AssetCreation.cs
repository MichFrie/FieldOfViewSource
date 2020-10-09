using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetCreation : MonoBehaviour
{
    public Transform[] cubes;
    public Transform prefab;
    public float xRotation;
    
    int gameObjectLength = 4;
    int i = 0;
   
    float xRot, yRot, zRot;

    public GameObject cubesParent;

    
    private void Awake()
    {
       
    
    }
    private void Start()
    {
       InvokeRepeating("ChooseRandomElement", 0f, 3f);
    }
    private void Update()
    {
        
       
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

    private void ChooseRandomElement()
    {
        cubesParent = new GameObject();
        cubesParent.AddComponent<MovementScript>();
        var randomNumber = UnityEngine.Random.Range(0,5);
        Debug.Log("randomNumber: " + randomNumber);
        switch (randomNumber)
        {
            
            case 0: J(); break;
            case 1: I(); break;
            case 2: L(); break;
            case 3: O(); break;
            case 4: S(); break;
            case 5: T(); break;
            case 6: Z(); break;
            default: Debug.Log("invalid case"); break;
        }      
    }
    private void J()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            if (i == 0)
            {
                prefabPosition.localPosition = Vector3.right * i;
            }
            else if (i == 1)
            {
                prefabPosition.localPosition = Vector3.forward * i;
            }
            else
            {
                prefabPosition.localPosition = Vector3.right * (i - 1);
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        i = 0;
    }
    private void I()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            prefabPosition.localPosition = (Vector3.right * i);
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        i = 0;
    }

    private void L()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);

            //cubes[i] = prefab;
            prefabPosition.localPosition = (Vector3.right * i);
            if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.right * (i - 1)) + (Vector3.forward * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        i = 0;
    }
    private void O()
    {
        while (i < 4)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            if (i == 0)
            {
                prefabPosition.localPosition = Vector3.right * i;
            }
            else if (i == 1)
            {
                prefabPosition.localPosition = Vector3.forward * i;
            }
            else if (i == 2)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 1)) + (Vector3.right * (i - 1));
            }
            else
            {
                prefabPosition.localPosition = (Vector3.right * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        i = 0;

    }
    void S()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            prefabPosition.localPosition = Vector3.right * i;
            if (i == 2)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 1)) + (Vector3.right * (i - 1));
            }
            else if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 2) + Vector3.right * (i - 1));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        i = 0;

    }

    private void T()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            prefabPosition.localPosition = Vector3.right * i;
            if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 2) + Vector3.right * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        i = 0;

    }
    private void Z()
    {
        while (i < gameObjectLength)
        {
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            //cubes[i] = prefab;
            if (i == 0)
            {
                prefabPosition.localPosition = Vector3.forward * (i + 1);
            }
            else if (i == 1)
            {
                prefabPosition.localPosition = (Vector3.forward * i + Vector3.right * i);
            }
            else if (i == 2)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 2) + Vector3.right * (i - 1));
            }
            else if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 3) + Vector3.right * (i - 1));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        i = 0;
    }
}

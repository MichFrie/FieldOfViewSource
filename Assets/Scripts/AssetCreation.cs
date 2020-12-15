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
    public Material[] materials;
    
    int gameObjectLength = 4;
    int i = 0;
   
    public GameObject cubesParent;

    private void Awake()
    {
        
    }
    private void Start()
    {     
    InvokeRepeating("ChooseRandomElement", 2.0f, 4.0f); 
        
    }

    private void ChooseRandomElement()
    {
        cubesParent = new GameObject();
        cubesParent.AddComponent<MovementScript>();
        var randomNumber = UnityEngine.Random.Range(0,5);
        switch (randomNumber)
        {
            
            case 0: I(); break;
            case 1: J(); break;
            case 2: L(); break;
            case 3: O(); break;
            case 4: S(); break;
            case 5: T(); break;
            case 6: Z(); break;
            default: Debug.Log("invalid case"); break;
        }
    }

    private void I()
    {
        while (i < gameObjectLength)
        {
            prefab.GetComponent<Renderer>().material = materials[0];
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            cubesParent.transform.position = new Vector3(0, 0, UnityEngine.Random.Range(-10, 10));
            prefabPosition.localPosition = (Vector3.right * i);
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        prefab.GetComponent<Renderer>().material = materials[7];
        i = 0;
    }
    private void J()
    {
        while (i < gameObjectLength)
        {
            prefab.GetComponent<Renderer>().material = materials[1];
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            cubesParent.transform.position = new Vector3(0, 0, UnityEngine.Random.Range(-10,10));
            
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
        prefab.GetComponent<Renderer>().material = materials[7];
        i = 0;
    }

    private void L()
    {
        while (i < gameObjectLength)
        {
            prefab.GetComponent<Renderer>().material = materials[2];
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            prefabPosition.localPosition = (Vector3.right * i);
            if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.right * (i - 1)) + (Vector3.forward * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        prefab.GetComponent<Renderer>().material = materials[7];
        i = 0;
    }
    private void O()
    {
        while (i < gameObjectLength)
        {
            prefab.GetComponent<Renderer>().material = materials[3];
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
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
        prefab.GetComponent<Renderer>().material = materials[7];
        i = 0;

    }
    void S()
    {
        while (i < gameObjectLength)
        {
            prefab.GetComponent<Renderer>().material = materials[4];
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
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
        prefab.GetComponent<Renderer>().material = materials[7];
        i = 0;

    }

    private void T()
    {
        while (i < gameObjectLength)
        {
            prefab.GetComponent<Renderer>().material = materials[5];
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
            prefabPosition.localPosition = Vector3.right * i;
            if (i == 3)
            {
                prefabPosition.localPosition = (Vector3.forward * (i - 2) + Vector3.right * (i - 2));
            }
            prefabPosition.localScale = Vector3.one / 1.05f;
            i++;
        }
        prefab.GetComponent<Renderer>().material = materials[7];
        i = 0;

    }
    private void Z()
    {
        while (i < gameObjectLength)
        {
            prefab.GetComponent<Renderer>().material = materials[6];
            Transform prefabPosition = Instantiate(prefab, cubesParent.transform);
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
        prefab.GetComponent<Renderer>().material = materials[7];
        i = 0;
    }
}
